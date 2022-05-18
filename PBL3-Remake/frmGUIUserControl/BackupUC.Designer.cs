namespace GUI.frmGUIUserControl
{
    partial class BackupUC
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
            this.dtpDayInputFood1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDataBackup = new System.Windows.Forms.Button();
            this.CalendarBackup = new System.Windows.Forms.MonthCalendar();
            this.btnBackup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDayInputFood1
            // 
            this.dtpDayInputFood1.Location = new System.Drawing.Point(924, 268);
            this.dtpDayInputFood1.Name = "dtpDayInputFood1";
            this.dtpDayInputFood1.Size = new System.Drawing.Size(200, 22);
            this.dtpDayInputFood1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(920, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Look up";
            // 
            // btnOpenDataBackup
            // 
            this.btnOpenDataBackup.Location = new System.Drawing.Point(924, 296);
            this.btnOpenDataBackup.Name = "btnOpenDataBackup";
            this.btnOpenDataBackup.Size = new System.Drawing.Size(125, 40);
            this.btnOpenDataBackup.TabIndex = 13;
            this.btnOpenDataBackup.Text = "Open backup file";
            this.btnOpenDataBackup.UseVisualStyleBackColor = true;
            // 
            // CalendarBackup
            // 
            this.CalendarBackup.Location = new System.Drawing.Point(922, 26);
            this.CalendarBackup.Name = "CalendarBackup";
            this.CalendarBackup.TabIndex = 12;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(922, 596);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(125, 40);
            this.btnBackup.TabIndex = 11;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 649);
            this.dataGridView1.TabIndex = 10;
            // 
            // BackupUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.dtpDayInputFood1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDataBackup);
            this.Controls.Add(this.CalendarBackup);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BackupUC";
            this.Size = new System.Drawing.Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDayInputFood1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDataBackup;
        private System.Windows.Forms.MonthCalendar CalendarBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
