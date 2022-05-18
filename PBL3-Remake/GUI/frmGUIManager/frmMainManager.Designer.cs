namespace PBL3_Remake.GUI.frmGUIManager
{
    partial class frmMainManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnUC = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnStatictis = new System.Windows.Forms.Button();
            this.btnWareHouse = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnOverView = new System.Windows.Forms.Button();
            this.backupUC = new PBL3_Remake.GUI.frmGUIUserControl.BackupUC();
            this.employeesUC = new PBL3_Remake.GUI.frmGUIUserControl.EmployeesUC();
            this.panel2.SuspendLayout();
            this.pnUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.btnStatictis);
            this.panel2.Controls.Add(this.btnWareHouse);
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Controls.Add(this.btnOverView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 700);
            this.panel2.TabIndex = 1;
            // 
            // pnUC
            // 
            this.pnUC.Controls.Add(this.employeesUC);
            this.pnUC.Controls.Add(this.backupUC);
            this.pnUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUC.Location = new System.Drawing.Point(200, 100);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(1200, 700);
            this.pnUC.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::PBL3_Remake.Properties.Resources.shutdown_48;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 80);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PBL3_Remake.Properties.Resources.askquestion_48;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 400);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 80);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::PBL3_Remake.Properties.Resources.clouds_48;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(0, 320);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 80);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnStatictis
            // 
            this.btnStatictis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatictis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnStatictis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatictis.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatictis.ForeColor = System.Drawing.Color.White;
            this.btnStatictis.Image = global::PBL3_Remake.Properties.Resources.chart_48;
            this.btnStatictis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatictis.Location = new System.Drawing.Point(0, 240);
            this.btnStatictis.Name = "btnStatictis";
            this.btnStatictis.Size = new System.Drawing.Size(200, 80);
            this.btnStatictis.TabIndex = 3;
            this.btnStatictis.Text = "Statictis";
            this.btnStatictis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatictis.UseVisualStyleBackColor = true;
            this.btnStatictis.Click += new System.EventHandler(this.btnStatictis_Click);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWareHouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWareHouse.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWareHouse.ForeColor = System.Drawing.Color.White;
            this.btnWareHouse.Image = global::PBL3_Remake.Properties.Resources.warehouse_48;
            this.btnWareHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWareHouse.Location = new System.Drawing.Point(0, 160);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Size = new System.Drawing.Size(200, 80);
            this.btnWareHouse.TabIndex = 2;
            this.btnWareHouse.Text = "Warehouse";
            this.btnWareHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWareHouse.UseVisualStyleBackColor = true;
            this.btnWareHouse.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::PBL3_Remake.Properties.Resources.Employee_48;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 80);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnOverView
            // 
            this.btnOverView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnOverView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverView.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverView.ForeColor = System.Drawing.Color.White;
            this.btnOverView.Image = global::PBL3_Remake.Properties.Resources.Overview_48;
            this.btnOverView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverView.Location = new System.Drawing.Point(0, 0);
            this.btnOverView.Name = "btnOverView";
            this.btnOverView.Size = new System.Drawing.Size(200, 80);
            this.btnOverView.TabIndex = 0;
            this.btnOverView.Text = "Overview";
            this.btnOverView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOverView.UseVisualStyleBackColor = true;
            this.btnOverView.Click += new System.EventHandler(this.btnOverView_Click);
            // 
            // backupUC
            // 
            this.backupUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.backupUC.Location = new System.Drawing.Point(120, 91);
            this.backupUC.Name = "backupUC";
            this.backupUC.Size = new System.Drawing.Size(161, 102);
            this.backupUC.TabIndex = 0;
            // 
            // employeesUC
            // 
            this.employeesUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.employeesUC.Location = new System.Drawing.Point(345, 86);
            this.employeesUC.Name = "employeesUC";
            this.employeesUC.Size = new System.Drawing.Size(173, 121);
            this.employeesUC.TabIndex = 1;
            // 
            // frmMainManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainManager";
            this.Load += new System.EventHandler(this.frmMainManager_Load);
            this.panel2.ResumeLayout(false);
            this.pnUC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnOverView;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnStatictis;
        private System.Windows.Forms.Button btnWareHouse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnUC;
        private frmGUIUserControl.EmployeesUC employeesUC;
        private frmGUIUserControl.BackupUC backupUC;
    }
}