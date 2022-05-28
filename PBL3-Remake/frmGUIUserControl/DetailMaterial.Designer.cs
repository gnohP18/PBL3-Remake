namespace GUI.frmGUIUserControl
{
    partial class DetailMaterial
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbbKindOfMaterial = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.lbTienDe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputMaterialName = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(208)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.txtID);
            this.panel7.Controls.Add(this.cbbKindOfMaterial);
            this.panel7.Controls.Add(this.btnClose);
            this.panel7.Controls.Add(this.btnAddNewMaterial);
            this.panel7.Controls.Add(this.lbTienDe);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtExpiry);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtUnit);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtInputMaterialName);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 337);
            this.panel7.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(90, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(141, 22);
            this.txtID.TabIndex = 17;
            // 
            // cbbKindOfMaterial
            // 
            this.cbbKindOfMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbKindOfMaterial.FormattingEnabled = true;
            this.cbbKindOfMaterial.Location = new System.Drawing.Point(35, 243);
            this.cbbKindOfMaterial.Name = "cbbKindOfMaterial";
            this.cbbKindOfMaterial.Size = new System.Drawing.Size(212, 24);
            this.cbbKindOfMaterial.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(183, 287);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 32);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAddNewMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAddNewMaterial.FlatAppearance.BorderSize = 2;
            this.btnAddNewMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMaterial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddNewMaterial.Location = new System.Drawing.Point(4, 287);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(123, 32);
            this.btnAddNewMaterial.TabIndex = 15;
            this.btnAddNewMaterial.Text = "OK";
            this.btnAddNewMaterial.UseVisualStyleBackColor = false;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // lbTienDe
            // 
            this.lbTienDe.AutoSize = true;
            this.lbTienDe.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.lbTienDe.Location = new System.Drawing.Point(71, 9);
            this.lbTienDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTienDe.Name = "lbTienDe";
            this.lbTienDe.Size = new System.Drawing.Size(160, 23);
            this.lbTienDe.TabIndex = 10;
            this.lbTienDe.Text = "Add new material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(35, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kind of material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(35, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expiry";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(35, 190);
            this.txtExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(212, 22);
            this.txtExpiry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(35, 137);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(212, 22);
            this.txtUnit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(35, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material name";
            // 
            // txtInputMaterialName
            // 
            this.txtInputMaterialName.Location = new System.Drawing.Point(35, 84);
            this.txtInputMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputMaterialName.Name = "txtInputMaterialName";
            this.txtInputMaterialName.Size = new System.Drawing.Size(212, 22);
            this.txtInputMaterialName.TabIndex = 1;
            // 
            // DetailMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(319, 334);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailMaterial";
            this.Text = "AddNewMaterial";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.Label lbTienDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputMaterialName;
        private System.Windows.Forms.ComboBox cbbKindOfMaterial;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
    }
}