namespace GUI.frmGUIUserControl
{
    partial class OverViewUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverViewUC));
            this.OverViewCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.Overviewchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.lblNumberofTableFl1 = new System.Windows.Forms.Label();
            this.lblNumberofTableFl2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConsuming = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblOrdered = new System.Windows.Forms.Label();
            this.RealTime = new System.Windows.Forms.Timer(this.components);
            this.lblRealTime = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Overviewchart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // OverViewCalendar
            // 
            this.OverViewCalendar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverViewCalendar.ForeColor = System.Drawing.Color.Black;
            this.OverViewCalendar.Location = new System.Drawing.Point(5, 5);
            this.OverViewCalendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.OverViewCalendar.Name = "OverViewCalendar";
            this.OverViewCalendar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(7, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 458);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblNumberofTableFl2);
            this.panel2.Controls.Add(this.lblNumberofTableFl1);
            this.panel2.Controls.Add(this.btnFloor2);
            this.panel2.Controls.Add(this.btnFloor1);
            this.panel2.Controls.Add(this.Overviewchart);
            this.panel2.Location = new System.Drawing.Point(241, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 301);
            this.panel2.TabIndex = 2;
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(244, 312);
            this.dgvDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.dgvDanhSachHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(952, 377);
            this.dgvDanhSachHoaDon.TabIndex = 3;
            this.dgvDanhSachHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellContentClick);
            // 
            // Overviewchart
            // 
            this.Overviewchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.AlignWithChartArea = "ChartArea1";
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(216)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.Name = "ChartArea1";
            this.Overviewchart.ChartAreas.Add(chartArea1);
            this.Overviewchart.Location = new System.Drawing.Point(3, 0);
            this.Overviewchart.Name = "Overviewchart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series0";
            series1.Points.Add(dataPoint1);
            this.Overviewchart.Series.Add(series1);
            this.Overviewchart.Size = new System.Drawing.Size(547, 298);
            this.Overviewchart.TabIndex = 31;
            this.Overviewchart.Text = "chart1";
            // 
            // btnFloor1
            // 
            this.btnFloor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnFloor1.FlatAppearance.BorderSize = 0;
            this.btnFloor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloor1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFloor1.Image = ((System.Drawing.Image)(resources.GetObject("btnFloor1.Image")));
            this.btnFloor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor1.Location = new System.Drawing.Point(566, 13);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor1.Size = new System.Drawing.Size(120, 50);
            this.btnFloor1.TabIndex = 32;
            this.btnFloor1.Text = "Floor 1";
            this.btnFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor1.UseVisualStyleBackColor = false;
            // 
            // btnFloor2
            // 
            this.btnFloor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnFloor2.FlatAppearance.BorderSize = 0;
            this.btnFloor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloor2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFloor2.Image = ((System.Drawing.Image)(resources.GetObject("btnFloor2.Image")));
            this.btnFloor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor2.Location = new System.Drawing.Point(766, 13);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor2.Size = new System.Drawing.Size(120, 50);
            this.btnFloor2.TabIndex = 33;
            this.btnFloor2.Text = "Floor 2";
            this.btnFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor2.UseVisualStyleBackColor = false;
            // 
            // lblNumberofTableFl1
            // 
            this.lblNumberofTableFl1.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblNumberofTableFl1.ForeColor = System.Drawing.Color.White;
            this.lblNumberofTableFl1.Location = new System.Drawing.Point(692, 29);
            this.lblNumberofTableFl1.Name = "lblNumberofTableFl1";
            this.lblNumberofTableFl1.Size = new System.Drawing.Size(63, 23);
            this.lblNumberofTableFl1.TabIndex = 34;
            this.lblNumberofTableFl1.Text = "A";
            this.lblNumberofTableFl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberofTableFl2
            // 
            this.lblNumberofTableFl2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblNumberofTableFl2.ForeColor = System.Drawing.Color.White;
            this.lblNumberofTableFl2.Location = new System.Drawing.Point(892, 29);
            this.lblNumberofTableFl2.Name = "lblNumberofTableFl2";
            this.lblNumberofTableFl2.Size = new System.Drawing.Size(60, 18);
            this.lblNumberofTableFl2.TabIndex = 35;
            this.lblNumberofTableFl2.Text = "B";
            this.lblNumberofTableFl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Location = new System.Drawing.Point(754, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 51);
            this.panel3.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(128, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PBL3_Remake.Properties.Resources.money_2_48;
            this.pictureBox4.Location = new System.Drawing.Point(0, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.lblTotal.Location = new System.Drawing.Point(8, 21);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "B";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lblProfit);
            this.panel5.Location = new System.Drawing.Point(754, 142);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 53);
            this.panel5.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(124, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_Remake.Properties.Resources.money_48;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblProfit
            // 
            this.lblProfit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(118)))));
            this.lblProfit.Location = new System.Drawing.Point(11, 25);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(156, 25);
            this.lblProfit.TabIndex = 5;
            this.lblProfit.Text = "D";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblConsuming);
            this.panel4.Location = new System.Drawing.Point(575, 142);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 51);
            this.panel4.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(69)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(89, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comsuming";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3_Remake.Properties.Resources.spending_32;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblConsuming
            // 
            this.lblConsuming.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsuming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(69)))), ((int)(((byte)(36)))));
            this.lblConsuming.Location = new System.Drawing.Point(13, 21);
            this.lblConsuming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsuming.Name = "lblConsuming";
            this.lblConsuming.Size = new System.Drawing.Size(159, 25);
            this.lblConsuming.TabIndex = 4;
            this.lblConsuming.Text = "C";
            this.lblConsuming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.lblOrdered);
            this.panel6.Location = new System.Drawing.Point(575, 87);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 51);
            this.panel6.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(104, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordered";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PBL3_Remake.Properties.Resources.Ordered_48;
            this.pictureBox3.Location = new System.Drawing.Point(4, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblOrdered
            // 
            this.lblOrdered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdered.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.lblOrdered.Location = new System.Drawing.Point(11, 21);
            this.lblOrdered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdered.Name = "lblOrdered";
            this.lblOrdered.Size = new System.Drawing.Size(160, 25);
            this.lblOrdered.TabIndex = 3;
            this.lblOrdered.Text = "A";
            this.lblOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RealTime
            // 
            this.RealTime.Tick += new System.EventHandler(this.RealTime_Tick);
            // 
            // lblRealTime
            // 
            this.lblRealTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblRealTime.Location = new System.Drawing.Point(3, 177);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(100, 23);
            this.lblRealTime.TabIndex = 31;
            this.lblRealTime.Text = "E";
            // 
            // OverViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.lblRealTime);
            this.Controls.Add(this.dgvDanhSachHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OverViewCalendar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OverViewUC";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.OverViewUC_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Overviewchart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar OverViewCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.DataVisualization.Charting.Chart Overviewchart;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Label lblNumberofTableFl2;
        private System.Windows.Forms.Label lblNumberofTableFl1;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsuming;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblOrdered;
        private System.Windows.Forms.Timer RealTime;
        private System.Windows.Forms.Label lblRealTime;
    }
}
