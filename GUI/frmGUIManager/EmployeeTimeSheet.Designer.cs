namespace GUI.frmGUIManager
{
    partial class EmployeeTimeSheet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTimeSheet));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID_User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName_User = new System.Windows.Forms.Label();
            this.DayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCoefficientsSalary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Time sheet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(133, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            // 
            // lblID_User
            // 
            this.lblID_User.AutoSize = true;
            this.lblID_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblID_User.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_User.ForeColor = System.Drawing.Color.Black;
            this.lblID_User.Location = new System.Drawing.Point(155, 8);
            this.lblID_User.Name = "lblID_User";
            this.lblID_User.Size = new System.Drawing.Size(22, 18);
            this.lblID_User.TabIndex = 28;
            this.lblID_User.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // lblName_User
            // 
            this.lblName_User.AutoSize = true;
            this.lblName_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblName_User.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_User.ForeColor = System.Drawing.Color.Black;
            this.lblName_User.Location = new System.Drawing.Point(70, 27);
            this.lblName_User.Name = "lblName_User";
            this.lblName_User.Size = new System.Drawing.Size(19, 18);
            this.lblName_User.TabIndex = 30;
            this.lblName_User.Text = "A";
            // 
            // DayChart
            // 
            this.DayChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.AlignWithChartArea = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.Name = "ChartArea1";
            this.DayChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            legend1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Time Sheet";
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.DayChart.Legends.Add(legend1);
            this.DayChart.Location = new System.Drawing.Point(12, 44);
            this.DayChart.Name = "DayChart";
            this.DayChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series0";
            series1.Points.Add(dataPoint1);
            this.DayChart.Series.Add(series1);
            this.DayChart.Size = new System.Drawing.Size(368, 330);
            this.DayChart.TabIndex = 32;
            this.DayChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Statistic time sheet";
            this.DayChart.Titles.Add(title1);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(920, 437);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 19);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAbsent
            // 
            this.lblAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAbsent.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsent.ForeColor = System.Drawing.Color.Black;
            this.lblAbsent.Location = new System.Drawing.Point(82, 5);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(90, 15);
            this.lblAbsent.TabIndex = 37;
            this.lblAbsent.Text = "B";
            this.lblAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Absent";
            // 
            // lblAttendance
            // 
            this.lblAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAttendance.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.ForeColor = System.Drawing.Color.Black;
            this.lblAttendance.Location = new System.Drawing.Point(82, 20);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(89, 15);
            this.lblAttendance.TabIndex = 39;
            this.lblAttendance.Text = "C";
            this.lblAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Attendance";
            // 
            // lblLate
            // 
            this.lblLate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLate.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLate.ForeColor = System.Drawing.Color.Black;
            this.lblLate.Location = new System.Drawing.Point(82, 38);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(89, 15);
            this.lblLate.TabIndex = 41;
            this.lblLate.Text = "D";
            this.lblLate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Late";
            // 
            // lblCoefficientsSalary
            // 
            this.lblCoefficientsSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCoefficientsSalary.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefficientsSalary.ForeColor = System.Drawing.Color.Black;
            this.lblCoefficientsSalary.Location = new System.Drawing.Point(291, 392);
            this.lblCoefficientsSalary.Name = "lblCoefficientsSalary";
            this.lblCoefficientsSalary.Size = new System.Drawing.Size(89, 15);
            this.lblCoefficientsSalary.TabIndex = 45;
            this.lblCoefficientsSalary.Text = "F";
            this.lblCoefficientsSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(193, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Coefficients salary";
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPosition.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Black;
            this.lblPosition.Location = new System.Drawing.Point(291, 377);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(90, 15);
            this.lblPosition.TabIndex = 43;
            this.lblPosition.Text = "E";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(193, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(185)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalSalary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(194, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 46);
            this.panel1.TabIndex = 46;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(185)))));
            this.lblTotalSalary.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalary.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalary.Location = new System.Drawing.Point(94, 27);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(89, 15);
            this.lblTotalSalary.TabIndex = 47;
            this.lblTotalSalary.Text = "G";
            this.lblTotalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(185)))));
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total";
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnPre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnPre.FlatAppearance.BorderSize = 2;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPre.Location = new System.Drawing.Point(462, 438);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(67, 19);
            this.btnPre.TabIndex = 35;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(676, 438);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 19);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Green;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblAttendance);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.lblAbsent);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.lblLate);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 380);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 57);
            this.guna2Panel1.TabIndex = 47;
            // 
            // EmployeeTimeSheet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 466);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCoefficientsSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.DayChart);
            this.Controls.Add(this.lblName_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeTimeSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeTimeSheet";
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName_User;
        private System.Windows.Forms.DataVisualization.Charting.Chart DayChart;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoefficientsSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}