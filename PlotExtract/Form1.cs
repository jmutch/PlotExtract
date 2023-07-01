using System.Windows.Forms;

namespace PlotExtract
{


    public partial class Form1 : Form
    {

        public enum GrabberState
        {
            idle = 0,
            calibrating_x_min = 1,
            calibrating_x_max = 2,
            calibrating_y_min = 3,
            calibrating_y_max = 4,
            calibrated = 5
        }

        //four points the user clicks. the first two (index 0 and index 1) will be at x min and x max, and we won't use the y values.
        //the second two (index 2 and index 3) will be at y min and y max, nad we won't use the x values.
        //this is redundant but simple, and allows the user to click at points where x is obvious and not y, or vice-versa
        PointD[] calibration_screen_points = new PointD[4] { new PointD(), new PointD(), new PointD(), new PointD() };

        //the following correspond to the value of the plot axis, not the screen coordinates.
        double calibated_x_min_value = 0.0f;
        double calibated_x_max_value = 1.0f;
        double calibated_y_min_value = 0.0f;
        double calibated_y_max_value = 1.0f;

        Pen pen = new Pen(Brushes.Red);

        private static int full_scale = 10000;

        public GrabberState _state = GrabberState.idle;
        public GrabberState state
        {
            get { return _state; }
            set
            {
                _state = value;
                switch (_state)
                {
                    case GrabberState.idle:
                        this.toolStripStatusLabel1.Text = "Needs calibration";
                        break;
                    case GrabberState.calibrating_x_min:
                        this.toolStripStatusLabel1.Text = "Click to place x minimum";
                        break;
                    case GrabberState.calibrating_x_max:
                        this.toolStripStatusLabel1.Text = "Click to place x maximum";
                        break;
                    case GrabberState.calibrating_y_min:
                        this.toolStripStatusLabel1.Text = "Click to place y minimum";
                        break;
                    case GrabberState.calibrating_y_max:
                        this.toolStripStatusLabel1.Text = "Click to place y maximum";
                        break;
                    case GrabberState.calibrated:
                        this.toolStripStatusLabel1.Text = "Calibrated";
                        break;
                    default:
                        this.toolStripStatusLabel1.Text = "";
                        break;
                }

            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string imagePath = openFileDialog.FileName;
                    pbPlot.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void calibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = GrabberState.calibrating_x_min;
            pbPlot.Invalidate();
        }

        private void pbPlot_MouseMove(object sender, MouseEventArgs e)
        {
            if (state > GrabberState.idle && state < GrabberState.calibrated)
            {
                this.Cursor = Cursors.Cross;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }

            if (state == GrabberState.calibrated && e != null)
            {
                PointD calibratedPoint = ScreenToCalibratedCoordinates(new Point(e.X, e.Y));
                if (calibratedPoint != null)
                {
                    toolStripStatusLabel2.Text = String.Format("({0:F2},{1:F2})", calibratedPoint.X, calibratedPoint.Y);
                }
            }
        }

        private void pbPlot_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pbPlot_MouseUp(object sender, MouseEventArgs e)
        {
            if (state == GrabberState.calibrated)
            {
                PointD calibratedPoint = ScreenToCalibratedCoordinates(new Point(e.X, e.Y));
                if (calibratedPoint != null)
                {
                    dataGridView1.Rows.Add(String.Format("{0:F2}", calibratedPoint.X),
                        String.Format("{0:F2}", calibratedPoint.Y));
                    Thread.Sleep(5);
                    pbPlot.Invalidate();
                }
            }
            else if (state > GrabberState.idle && state < GrabberState.calibrated)
            {
                calibration_screen_points[(int)state - 1].X = (int)(e.X / (double)pbPlot.Width * full_scale);
                calibration_screen_points[(int)state - 1].Y = (int)(e.Y / (double)pbPlot.Height * full_scale);
                state = state + 1;
                pbPlot.Invalidate();
            }

        }

        //converts point p in range 0 to full_scale to screen coordinates

        private PointD ConvertToScreenPoint(PointD p)
        {
            PointD p2 = new PointD();
            p2.X = (int)(p.X / (double)full_scale * pbPlot.Width);
            p2.Y = (int)(p.Y / (double)full_scale * pbPlot.Height);
            return p2;
        }
        private Point PointDToPoint(PointD p)
        {
            return new Point((int)p.X, (int)p.Y);
        }

        private void pbPlot_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < (int)state - 1; i++)
            {
                if (i < calibration_screen_points.Length)
                {
                    g.DrawRectangle(pen, new Rectangle(PointDToPoint(ConvertToScreenPoint(calibration_screen_points[i])), new Size(6, 6)));
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string xs = (string)dataGridView1.Rows[i].Cells[0].Value;
                string ys = (string)dataGridView1.Rows[i].Cells[1].Value;
                if (xs != null && ys != null)
                {
                    double x;
                    double y;
                    double.TryParse(xs, out x);
                    double.TryParse(ys, out y);
                    PointD p = new PointD(x, y);
                    p = CalibratedCoordinateToScreen(p);

                    g.DrawRectangle(pen, new Rectangle(PointDToPoint(p), new Size(3, 3)));
                }
            }
        }

        //nullable point in case we don't have a calibration set up.
        //if there isn't a calibration, return null
        private PointD? ScreenToCalibratedCoordinates(Point p_screen)
        {
            if (state != GrabberState.calibrated)
            {
                return null;
            }
            PointD p = new PointD();

            PointD x_min_point = ConvertToScreenPoint(calibration_screen_points[0]);
            PointD x_max_point = ConvertToScreenPoint(calibration_screen_points[1]);
            PointD y_min_point = ConvertToScreenPoint(calibration_screen_points[2]);
            PointD y_max_point = ConvertToScreenPoint(calibration_screen_points[3]);
            double fraction_x = (p_screen.X - x_min_point.X) / (x_max_point.X - x_min_point.X);
            double fraction_y = (p_screen.Y - y_min_point.Y) / (y_max_point.Y - y_min_point.Y);

            p.X = fraction_x * (calibated_x_max_value - calibated_x_min_value) + calibated_x_min_value;
            p.Y = fraction_y * (calibated_y_max_value - calibated_y_min_value) + calibated_y_min_value;

            return p;


        }
        private PointD? CalibratedCoordinateToScreen(PointD p_cal)
        {
            if (state != GrabberState.calibrated)
            {
                return null;
            }
            PointD p = new PointD();

            PointD x_min_point = ConvertToScreenPoint(calibration_screen_points[0]);
            PointD x_max_point = ConvertToScreenPoint(calibration_screen_points[1]);
            PointD y_min_point = ConvertToScreenPoint(calibration_screen_points[2]);
            PointD y_max_point = ConvertToScreenPoint(calibration_screen_points[3]);

            double fraction_x = (p_cal.X - calibated_x_min_value) / (calibated_x_max_value - calibated_x_min_value);
            double fraction_y = (p_cal.Y - calibated_y_min_value) / (calibated_y_max_value - calibated_y_min_value);

            p.X = fraction_x * (x_max_point.X - x_min_point.X) + x_min_point.X;
            p.Y = fraction_y * (y_max_point.Y - y_min_point.Y) + y_min_point.Y;

            return p;


        }

        private void nm_x_min_ValueChanged(object sender, EventArgs e)
        {
            calibated_x_min_value = (double)nm_x_min.Value;
        }

        private void nm_y_min_ValueChanged(object sender, EventArgs e)
        {
            calibated_y_min_value = (double)nm_y_min.Value;
        }

        private void nm_x_max_ValueChanged(object sender, EventArgs e)
        {
            calibated_x_max_value = (double)nm_x_max.Value;
        }

        private void nm_y_max_ValueChanged(object sender, EventArgs e)
        {
            calibated_y_max_value = (double)nm_y_max.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calibated_x_min_value = (double)nm_x_min.Value;
            calibated_y_min_value = (double)nm_y_min.Value;
            calibated_x_max_value = (double)nm_x_max.Value;
            calibated_y_max_value = (double)nm_y_max.Value;

        }

    }
}