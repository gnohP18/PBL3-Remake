namespace GUI.frmGUIUserControl
{
    partial class SalaryManageUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvSalaryEmployee = new System.Windows.Forms.DataGridView();
            this.pBUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblID_User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDayWork = new System.Windows.Forms.Label();
            this.lblCoefficientsSalary = new System.Windows.Forms.Label();
            this.lblTotalDayWork = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DayWorkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pBCondition = new System.Windows.Forms.PictureBox();
            this.lblPercentWorkHard = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayWorkChart)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalaryEmployee
            // 
            this.dgvSalaryEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSalaryEmployee.EnableHeadersVisualStyles = false;
            this.dgvSalaryEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.dgvSalaryEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvSalaryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalaryEmployee.Name = "dgvSalaryEmployee";
            this.dgvSalaryEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaryEmployee.RowHeadersVisible = false;
            this.dgvSalaryEmployee.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.dgvSalaryEmployee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalaryEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryEmployee.Size = new System.Drawing.Size(717, 700);
            this.dgvSalaryEmployee.TabIndex = 1;
            this.dgvSalaryEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryEmployee_CellContentClick);
            // 
            // pBUserPicture
            // 
            this.pBUserPicture.ImageRotate = 0F;
            this.pBUserPicture.Location = new System.Drawing.Point(847, 24);
            this.pBUserPicture.Name = "pBUserPicture";
            this.pBUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pBUserPicture.Size = new System.Drawing.Size(128, 128);
            this.pBUserPicture.TabIndex = 2;
            this.pBUserPicture.TabStop = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.White;
            this.lblNameUser.Location = new System.Drawing.Point(165, 40);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(228, 21);
            this.lblNameUser.TabIndex = 10;
            this.lblNameUser.Text = "B";
            // 
            // lblID_User
            // 
            this.lblID_User.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_User.ForeColor = System.Drawing.Color.White;
            this.lblID_User.Location = new System.Drawing.Point(164, 5);
            this.lblID_User.Name = "lblID_User";
            this.lblID_User.Size = new System.Drawing.Size(229, 21);
            this.lblID_User.TabIndex = 11;
            this.lblID_User.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(831, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Salary information";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(166, 71);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(227, 21);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "C";
            // 
            // lblDayWork
            // 
            this.lblDayWork.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayWork.ForeColor = System.Drawing.Color.White;
            this.lblDayWork.Location = new System.Drawing.Point(166, 140);
            this.lblDayWork.Name = "lblDayWork";
            this.lblDayWork.Size = new System.Drawing.Size(227, 21);
            this.lblDayWork.TabIndex = 14;
            this.lblDayWork.Text = "E";
            // 
            // lblCoefficientsSalary
            // 
            this.lblCoefficientsSalary.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefficientsSalary.ForeColor = System.Drawing.Color.White;
            this.lblCoefficientsSalary.Location = new System.Drawing.Point(166, 105);
            this.lblCoefficientsSalary.Name = "lblCoefficientsSalary";
            this.lblCoefficientsSalary.Size = new System.Drawing.Size(227, 21);
            this.lblCoefficientsSalary.TabIndex = 15;
            this.lblCoefficientsSalary.Text = "D";
            // 
            // lblTotalDayWork
            // 
            this.lblTotalDayWork.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDayWork.ForeColor = System.Drawing.Color.White;
            this.lblTotalDayWork.Location = new System.Drawing.Point(166, 174);
            this.lblTotalDayWork.Name = "lblTotalDayWork";
            this.lblTotalDayWork.Size = new System.Drawing.Size(227, 21);
            this.lblTotalDayWork.TabIndex = 16;
            this.lblTotalDayWork.Text = "F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Day work";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total day Work";
            // 
            // DayWorkChart
            // 
            this.DayWorkChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.AlignWithChartArea = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            chartArea1.Name = "ChartArea1";
            this.DayWorkChart.ChartAreas.Add(chartArea1);
            this.DayWorkChart.Location = new System.Drawing.Point(724, 471);
            this.DayWorkChart.Name = "DayWorkChart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "Series0";
            series1.Points.Add(dataPoint1);
            this.DayWorkChart.Series.Add(series1);
            this.DayWorkChart.Size = new System.Drawing.Size(209, 222);
            this.DayWorkChart.TabIndex = 30;
            this.DayWorkChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Day work";
            this.DayWorkChart.Titles.Add(title1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(100, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Proposal for promotion";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pBCondition);
            this.guna2GradientPanel1.Controls.Add(this.lblPercentWorkHard);
            this.guna2GradientPanel1.Controls.Add(this.label9);
            this.guna2GradientPanel1.Controls.Add(this.lblPosition);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.lblNameUser);
            this.guna2GradientPanel1.Controls.Add(this.lblID_User);
            this.guna2GradientPanel1.Controls.Add(this.lblDayWork);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.lblCoefficientsSalary);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.lblTotalDayWork);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(724, 158);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(401, 265);
            this.guna2GradientPanel1.TabIndex = 33;
            // 
            // pBCondition
            // 
            this.pBCondition.Location = new System.Drawing.Point(297, 232);
            this.pBCondition.Name = "pBCondition";
            this.pBCondition.Size = new System.Drawing.Size(32, 32);
            this.pBCondition.TabIndex = 35;
            this.pBCondition.TabStop = false;
            // 
            // lblPercentWorkHard
            // 
            this.lblPercentWorkHard.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentWorkHard.ForeColor = System.Drawing.Color.White;
            this.lblPercentWorkHard.Location = new System.Drawing.Point(166, 205);
            this.lblPercentWorkHard.Name = "lblPercentWorkHard";
            this.lblPercentWorkHard.Size = new System.Drawing.Size(227, 21);
            this.lblPercentWorkHard.TabIndex = 34;
            this.lblPercentWorkHard.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Percent Work hard";
            // 
            // cbbPosition
            // 
            this.cbbPosition.BackColor = System.Drawing.Color.Transparent;
            this.cbbPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbbPosition.BorderRadius = 15;
            this.cbbPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPosition.ItemHeight = 30;
            this.cbbPosition.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbPosition.Location = new System.Drawing.Point(828, 429);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(187, 36);
            this.cbbPosition.TabIndex = 42;
            // 
            // SalaryManageUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.cbbPosition);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.DayWorkChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBUserPicture);
            this.Controls.Add(this.dgvSalaryEmployee);
            this.Name = "SalaryManageUC";
            this.Size = new System.Drawing.Size(1125, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayWorkChart)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalaryEmployee;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pBUserPicture;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblID_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDayWork;
        private System.Windows.Forms.Label lblCoefficientsSalary;
        private System.Windows.Forms.Label lblTotalDayWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart DayWorkChart;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblPercentWorkHard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBCondition;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPosition;
    }
}
