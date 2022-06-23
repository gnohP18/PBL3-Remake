namespace GUI.frmGUISeller
{
    partial class frmMainSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSeller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnDetailTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.cbbStatusTable = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTable = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnAttend);
            this.panel1.Controls.Add(this.btnDetailTable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnFloor2);
            this.panel1.Controls.Add(this.btnFloor1);
            this.panel1.Controls.Add(this.cbbStatusTable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnAttend
            // 
            this.btnAttend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAttend.FlatAppearance.BorderSize = 0;
            this.btnAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttend.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttend.Image = global::PBL3_Remake.Properties.Resources.networking_32;
            this.btnAttend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttend.Location = new System.Drawing.Point(479, 24);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAttend.Size = new System.Drawing.Size(176, 50);
            this.btnAttend.TabIndex = 28;
            this.btnAttend.Text = "Attendance";
            this.btnAttend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttend.UseVisualStyleBackColor = false;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnDetailTable
            // 
            this.btnDetailTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnDetailTable.FlatAppearance.BorderSize = 0;
            this.btnDetailTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailTable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetailTable.Image = global::PBL3_Remake.Properties.Resources.detail_table_icons;
            this.btnDetailTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailTable.Location = new System.Drawing.Point(269, 26);
            this.btnDetailTable.Name = "btnDetailTable";
            this.btnDetailTable.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDetailTable.Size = new System.Drawing.Size(165, 50);
            this.btnDetailTable.TabIndex = 27;
            this.btnDetailTable.Text = "Detail table";
            this.btnDetailTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetailTable.UseVisualStyleBackColor = false;
            this.btnDetailTable.Click += new System.EventHandler(this.btnDetailTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(735, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(109, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employee";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::PBL3_Remake.Properties.Resources.exit_32;
            this.btnExit.Location = new System.Drawing.Point(23, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnFloor2.Location = new System.Drawing.Point(1168, 26);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor2.Size = new System.Drawing.Size(120, 50);
            this.btnFloor2.TabIndex = 21;
            this.btnFloor2.Text = "Floor 2";
            this.btnFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor2.UseVisualStyleBackColor = false;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
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
            this.btnFloor1.Location = new System.Drawing.Point(1048, 26);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor1.Size = new System.Drawing.Size(120, 50);
            this.btnFloor1.TabIndex = 20;
            this.btnFloor1.Text = "Floor 1";
            this.btnFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor1.UseVisualStyleBackColor = false;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // cbbStatusTable
            // 
            this.cbbStatusTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbStatusTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatusTable.FormattingEnabled = true;
            this.cbbStatusTable.Location = new System.Drawing.Point(875, 41);
            this.cbbStatusTable.Name = "cbbStatusTable";
            this.cbbStatusTable.Size = new System.Drawing.Size(167, 21);
            this.cbbStatusTable.TabIndex = 18;
            this.cbbStatusTable.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = global::PBL3_Remake.Properties.Resources.icon_32;
            this.pictureBox1.Location = new System.Drawing.Point(71, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pnTable
            // 
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 100);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(1300, 600);
            this.pnTable.TabIndex = 1;
            // 
            // frmMainSeller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMainSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainSeller";
            this.Load += new System.EventHandler(this.frmMainSeller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.ComboBox cbbStatusTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Button btnDetailTable;
        private System.Windows.Forms.Button btnAttend;
    }
}