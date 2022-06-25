namespace GUI.frmGUISeller
{
    partial class DetailTable
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReady = new Guna.UI2.WinForms.Guna2Button();
            this.btnNoReady = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInforFoodWareHouse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvStatusDish = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(219, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Detail table";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::PBL3_Remake.Properties.Resources.exit_32;
            this.btnClose.Location = new System.Drawing.Point(527, 19);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnClose.Size = new System.Drawing.Size(48, 48);
            this.btnClose.TabIndex = 28;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnReady.BorderRadius = 5;
            this.btnReady.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReady.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReady.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReady.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReady.FillColor = System.Drawing.Color.SlateBlue;
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.ForeColor = System.Drawing.Color.White;
            this.btnReady.Image = global::PBL3_Remake.Properties.Resources.checkedGreen;
            this.btnReady.Location = new System.Drawing.Point(33, 41);
            this.btnReady.Margin = new System.Windows.Forms.Padding(2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(135, 37);
            this.btnReady.TabIndex = 29;
            this.btnReady.Text = "Ready dish";
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnNoReady
            // 
            this.btnNoReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnNoReady.BorderRadius = 5;
            this.btnNoReady.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNoReady.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNoReady.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNoReady.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNoReady.FillColor = System.Drawing.Color.SlateBlue;
            this.btnNoReady.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoReady.ForeColor = System.Drawing.Color.White;
            this.btnNoReady.Image = global::PBL3_Remake.Properties.Resources.uncheckedRed;
            this.btnNoReady.Location = new System.Drawing.Point(425, 41);
            this.btnNoReady.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoReady.Name = "btnNoReady";
            this.btnNoReady.Size = new System.Drawing.Size(135, 37);
            this.btnNoReady.TabIndex = 29;
            this.btnNoReady.Text = "No ready dish";
            this.btnNoReady.Click += new System.EventHandler(this.btnNoReady_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.guna2Panel1.Controls.Add(this.btnInforFoodWareHouse);
            this.guna2Panel1.Controls.Add(this.btnNoReady);
            this.guna2Panel1.Controls.Add(this.btnReady);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(586, 87);
            this.guna2Panel1.TabIndex = 31;
            // 
            // btnInforFoodWareHouse
            // 
            this.btnInforFoodWareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnInforFoodWareHouse.BorderRadius = 5;
            this.btnInforFoodWareHouse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInforFoodWareHouse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInforFoodWareHouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInforFoodWareHouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInforFoodWareHouse.FillColor = System.Drawing.Color.SlateBlue;
            this.btnInforFoodWareHouse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforFoodWareHouse.ForeColor = System.Drawing.Color.White;
            this.btnInforFoodWareHouse.Location = new System.Drawing.Point(224, 41);
            this.btnInforFoodWareHouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnInforFoodWareHouse.Name = "btnInforFoodWareHouse";
            this.btnInforFoodWareHouse.Size = new System.Drawing.Size(135, 37);
            this.btnInforFoodWareHouse.TabIndex = 29;
            this.btnInforFoodWareHouse.Text = "WareHouse";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnClose);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 354);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(586, 78);
            this.guna2Panel3.TabIndex = 33;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvStatusDish);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 87);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(586, 263);
            this.guna2Panel2.TabIndex = 32;
            // 
            // dgvStatusDish
            // 
            this.dgvStatusDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusDish.Location = new System.Drawing.Point(33, 18);
            this.dgvStatusDish.Name = "dgvStatusDish";
            this.dgvStatusDish.Size = new System.Drawing.Size(527, 212);
            this.dgvStatusDish.TabIndex = 0;
            // 
            // DetailTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(586, 432);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailTable";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusDish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnReady;
        private Guna.UI2.WinForms.Guna2Button btnNoReady;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnInforFoodWareHouse;
        private System.Windows.Forms.DataGridView dgvStatusDish;
    }
}