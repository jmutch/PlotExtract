namespace PlotExtract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbPlot = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            calibrationToolStripMenuItem = new ToolStripMenuItem();
            startCalibrationToolStripMenuItem = new ToolStripMenuItem();
            pnlLeft = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            pnlRight = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nm_y_max = new NumericUpDown();
            nm_y_min = new NumericUpDown();
            nm_x_max = new NumericUpDown();
            nm_x_min = new NumericUpDown();
            dataGridView1 = new DataGridView();
            x_col = new DataGridViewTextBoxColumn();
            y_col = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbPlot).BeginInit();
            menuStrip1.SuspendLayout();
            pnlLeft.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_y_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nm_y_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nm_x_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nm_x_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbPlot
            // 
            pbPlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPlot.BorderStyle = BorderStyle.FixedSingle;
            pbPlot.Location = new Point(3, 3);
            pbPlot.Name = "pbPlot";
            pbPlot.Size = new Size(766, 602);
            pbPlot.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlot.TabIndex = 0;
            pbPlot.TabStop = false;
            pbPlot.Paint += pbPlot_Paint;
            pbPlot.MouseLeave += pbPlot_MouseLeave;
            pbPlot.MouseMove += pbPlot_MouseMove;
            pbPlot.MouseUp += pbPlot_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, calibrationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(136, 22);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // calibrationToolStripMenuItem
            // 
            calibrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startCalibrationToolStripMenuItem });
            calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            calibrationToolStripMenuItem.Size = new Size(77, 20);
            calibrationToolStripMenuItem.Text = "Calibration";
            calibrationToolStripMenuItem.Click += calibrationToolStripMenuItem_Click;
            // 
            // startCalibrationToolStripMenuItem
            // 
            startCalibrationToolStripMenuItem.Name = "startCalibrationToolStripMenuItem";
            startCalibrationToolStripMenuItem.Size = new Size(159, 22);
            startCalibrationToolStripMenuItem.Text = "Start Calibration";
            startCalibrationToolStripMenuItem.Click += startCalibrationToolStripMenuItem_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLeft.Controls.Add(pbPlot);
            pnlLeft.Location = new Point(12, 27);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(781, 608);
            pnlLeft.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 638);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1098, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "Needs calibrated";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(113, 17);
            toolStripStatusLabel2.Text = "Mouse Coordinates:";
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRight.Controls.Add(label5);
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(label1);
            pnlRight.Controls.Add(nm_y_max);
            pnlRight.Controls.Add(nm_y_min);
            pnlRight.Controls.Add(nm_x_max);
            pnlRight.Controls.Add(nm_x_min);
            pnlRight.Controls.Add(dataGridView1);
            pnlRight.Location = new Point(799, 27);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(297, 608);
            pnlRight.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 24);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "Plot coordinates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 48);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 48);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 6;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 5;
            label1.Text = "X:";
            // 
            // nm_y_max
            // 
            nm_y_max.DecimalPlaces = 2;
            nm_y_max.Location = new Point(150, 95);
            nm_y_max.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nm_y_max.Minimum = new decimal(new int[] { 276447232, 23283, 0, int.MinValue });
            nm_y_max.Name = "nm_y_max";
            nm_y_max.Size = new Size(92, 23);
            nm_y_max.TabIndex = 4;
            nm_y_max.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nm_y_max.ValueChanged += nm_y_max_ValueChanged;
            // 
            // nm_y_min
            // 
            nm_y_min.DecimalPlaces = 2;
            nm_y_min.Location = new Point(52, 95);
            nm_y_min.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nm_y_min.Minimum = new decimal(new int[] { 276447232, 23283, 0, int.MinValue });
            nm_y_min.Name = "nm_y_min";
            nm_y_min.Size = new Size(92, 23);
            nm_y_min.TabIndex = 3;
            nm_y_min.ValueChanged += nm_y_min_ValueChanged;
            // 
            // nm_x_max
            // 
            nm_x_max.DecimalPlaces = 2;
            nm_x_max.Location = new Point(150, 66);
            nm_x_max.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nm_x_max.Minimum = new decimal(new int[] { 276447232, 23283, 0, int.MinValue });
            nm_x_max.Name = "nm_x_max";
            nm_x_max.Size = new Size(92, 23);
            nm_x_max.TabIndex = 2;
            nm_x_max.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nm_x_max.ValueChanged += nm_x_max_ValueChanged;
            // 
            // nm_x_min
            // 
            nm_x_min.DecimalPlaces = 2;
            nm_x_min.Location = new Point(52, 66);
            nm_x_min.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nm_x_min.Minimum = new decimal(new int[] { 276447232, 23283, 0, int.MinValue });
            nm_x_min.Name = "nm_x_min";
            nm_x_min.Size = new Size(92, 23);
            nm_x_min.TabIndex = 1;
            nm_x_min.ValueChanged += nm_x_min_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x_col, y_col });
            dataGridView1.Location = new Point(31, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(244, 446);
            dataGridView1.TabIndex = 0;
            // 
            // x_col
            // 
            x_col.HeaderText = "X";
            x_col.Name = "x_col";
            // 
            // y_col
            // 
            y_col.HeaderText = "Y";
            y_col.Name = "y_col";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 660);
            Controls.Add(pnlRight);
            Controls.Add(statusStrip1);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbPlot).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_y_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)nm_y_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)nm_x_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)nm_x_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPlot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private Panel pnlLeft;
        private ToolStripMenuItem calibrationToolStripMenuItem;
        private ToolStripMenuItem startCalibrationToolStripMenuItem;
        private StatusStrip statusStrip1;
        private Panel pnlRight;
        private DataGridView dataGridView1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private NumericUpDown nm_x_max;
        private NumericUpDown nm_x_min;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nm_y_max;
        private NumericUpDown nm_y_min;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private DataGridViewTextBoxColumn x_col;
        private DataGridViewTextBoxColumn y_col;
    }
}