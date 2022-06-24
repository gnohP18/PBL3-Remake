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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReady = new Guna.UI2.WinForms.Guna2Button();
            this.btnNoReady = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvStatusDish = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusDish)).BeginInit();
            this.guna2Panel2.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(219, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Detail table";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::PBL3_Remake.Properties.Resources.exit_32;
            this.button1.Location = new System.Drawing.Point(478, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button1.Size = new System.Drawing.Size(82, 44);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnReady.Location = new System.Drawing.Point(33, 68);
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
            this.btnNoReady.Location = new System.Drawing.Point(399, 68);
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
            this.guna2Panel1.Controls.Add(this.btnNoReady);
            this.guna2Panel1.Controls.Add(this.btnReady);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(586, 117);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.button1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 401);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(586, 81);
            this.guna2Panel3.TabIndex = 33;
            // 
            // dgvStatusDish
            // 
            this.dgvStatusDish.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStatusDish.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatusDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatusDish.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatusDish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatusDish.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStatusDish.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusDish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatusDish.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatusDish.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatusDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatusDish.EnableHeadersVisualStyles = false;
            this.dgvStatusDish.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStatusDish.Location = new System.Drawing.Point(0, 0);
            this.dgvStatusDish.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStatusDish.Name = "dgvStatusDish";
            this.dgvStatusDish.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusDish.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStatusDish.RowHeadersVisible = false;
            this.dgvStatusDish.RowHeadersWidth = 51;
            this.dgvStatusDish.RowTemplate.Height = 24;
            this.dgvStatusDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusDish.Size = new System.Drawing.Size(586, 365);
            this.dgvStatusDish.TabIndex = 30;
            this.dgvStatusDish.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStatusDish.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStatusDish.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStatusDish.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStatusDish.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStatusDish.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStatusDish.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStatusDish.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStatusDish.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStatusDish.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStatusDish.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStatusDish.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStatusDish.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvStatusDish.ThemeStyle.ReadOnly = false;
            this.dgvStatusDish.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStatusDish.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStatusDish.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStatusDish.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStatusDish.ThemeStyle.RowsStyle.Height = 24;
            this.dgvStatusDish.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStatusDish.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvStatusDish);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 117);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(586, 365);
            this.guna2Panel2.TabIndex = 32;
            // 
            // DetailTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(586, 482);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusDish)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btnReady;
        private Guna.UI2.WinForms.Guna2Button btnNoReady;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStatusDish;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}