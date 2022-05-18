namespace PBL3_Remake.GUI.frmGUIUserControl
{
    partial class InfoFood
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
            this.btClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInforInputFood = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforInputFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(56, 557);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 30);
            this.btClose.TabIndex = 36;
            this.btClose.Text = "CLose";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(172, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(644, 557);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(644, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(294, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Food information";
            // 
            // dgvInforInputFood
            // 
            this.dgvInforInputFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforInputFood.Location = new System.Drawing.Point(56, 260);
            this.dgvInforInputFood.Name = "dgvInforInputFood";
            this.dgvInforInputFood.RowHeadersWidth = 51;
            this.dgvInforInputFood.RowTemplate.Height = 24;
            this.dgvInforInputFood.Size = new System.Drawing.Size(688, 287);
            this.dgvInforInputFood.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtTenNhaCungCap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaNhaCungCap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtInputDay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCurrentQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFoodID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 204);
            this.panel1.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(480, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 64;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(519, 162);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(156, 22);
            this.txtTenNhaCungCap.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(349, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Name manufacture";
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(168, 162);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(175, 22);
            this.txtMaNhaCungCap.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "ID manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(348, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Kind of food";
            // 
            // txtInputDay
            // 
            this.txtInputDay.Location = new System.Drawing.Point(166, 92);
            this.txtInputDay.Name = "txtInputDay";
            this.txtInputDay.Size = new System.Drawing.Size(175, 22);
            this.txtInputDay.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Input day";
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Location = new System.Drawing.Point(166, 52);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(175, 22);
            this.txtCurrentQuantity.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Current quantity";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(480, 20);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(199, 22);
            this.txtFoodName.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(348, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Food name";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(166, 19);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(175, 22);
            this.txtFoodID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Food ID";
            // 
            // InfoFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvInforInputFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoFood";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforInputFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInforInputFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label1;
    }
}