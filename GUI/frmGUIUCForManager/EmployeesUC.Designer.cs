namespace GUI.frmGUIUCForManager
{
    partial class EmployeesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSalaryManage = new System.Windows.Forms.Button();
            this.btnTimeSheetEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pBDGV = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dgvManageEmployee = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDGV)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnSalaryManage);
            this.panel1.Controls.Add(this.btnTimeSheetEmployee);
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.pBDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 700);
            this.panel1.TabIndex = 2;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(0, 341);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 65);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSalaryManage
            // 
            this.btnSalaryManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalaryManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnSalaryManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryManage.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryManage.ForeColor = System.Drawing.Color.White;
            this.btnSalaryManage.Image = global::GUI.Properties.Resources.salary_48;
            this.btnSalaryManage.Location = new System.Drawing.Point(0, 276);
            this.btnSalaryManage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalaryManage.Name = "btnSalaryManage";
            this.btnSalaryManage.Size = new System.Drawing.Size(75, 65);
            this.btnSalaryManage.TabIndex = 9;
            this.btnSalaryManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaryManage.UseVisualStyleBackColor = true;
            this.btnSalaryManage.Click += new System.EventHandler(this.btnSalaryManage_Click);
            // 
            // btnTimeSheetEmployee
            // 
            this.btnTimeSheetEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeSheetEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnTimeSheetEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSheetEmployee.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSheetEmployee.ForeColor = System.Drawing.Color.White;
            this.btnTimeSheetEmployee.Image = global::GUI.Properties.Resources.calendar_48;
            this.btnTimeSheetEmployee.Location = new System.Drawing.Point(0, 211);
            this.btnTimeSheetEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeSheetEmployee.Name = "btnTimeSheetEmployee";
            this.btnTimeSheetEmployee.Size = new System.Drawing.Size(75, 65);
            this.btnTimeSheetEmployee.TabIndex = 8;
            this.btnTimeSheetEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimeSheetEmployee.UseVisualStyleBackColor = true;
            this.btnTimeSheetEmployee.Click += new System.EventHandler(this.btnTimeSheetEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Image = global::GUI.Properties.Resources.Removeperson_48;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(0, 146);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 65);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = global::GUI.Properties.Resources.Addperson_48;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 81);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 65);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click_1);
            // 
            // pBDGV
            // 
            this.pBDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBDGV.Location = new System.Drawing.Point(0, 0);
            this.pBDGV.Margin = new System.Windows.Forms.Padding(2);
            this.pBDGV.Name = "pBDGV";
            this.pBDGV.Size = new System.Drawing.Size(75, 81);
            this.pBDGV.TabIndex = 0;
            this.pBDGV.TabStop = false;
            this.pBDGV.Click += new System.EventHandler(this.pBDGV_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dgvManageEmployee);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(75, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1125, 700);
            this.pnMain.TabIndex = 3;
            // 
            // dgvManageEmployee
            // 
            this.dgvManageEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvManageEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManageEmployee.EnableHeadersVisualStyles = false;
            this.dgvManageEmployee.GridColor = System.Drawing.Color.White;
            this.dgvManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvManageEmployee.Name = "dgvManageEmployee";
            this.dgvManageEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageEmployee.RowHeadersVisible = false;
            this.dgvManageEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.dgvManageEmployee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManageEmployee.RowTemplate.Height = 24;
            this.dgvManageEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageEmployee.Size = new System.Drawing.Size(1125, 700);
            this.dgvManageEmployee.TabIndex = 44;
            this.dgvManageEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageEmployee_CellContentDoubleClick);
            // 
            // EmployeesUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeesUC";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.EmployeesUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBDGV)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.PictureBox pBDGV;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnTimeSheetEmployee;
        private System.Windows.Forms.Button btnSalaryManage;
        private System.Windows.Forms.DataGridView dgvManageEmployee;
        private System.Windows.Forms.Button btnInfo;
    }
}
