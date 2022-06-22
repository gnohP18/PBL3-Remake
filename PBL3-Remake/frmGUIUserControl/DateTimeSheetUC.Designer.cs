namespace GUI.frmGUIUserControl
{
    partial class DateTimeSheetUC
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
            this.pnText = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnAfternoon = new System.Windows.Forms.Panel();
            this.pnMorning = new System.Windows.Forms.Panel();
            this.pnText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnText.Controls.Add(this.lblDate);
            this.pnText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnText.Location = new System.Drawing.Point(0, 0);
            this.pnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(93, 25);
            this.pnText.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "A";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnAfternoon
            // 
            this.pnAfternoon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAfternoon.Location = new System.Drawing.Point(47, 25);
            this.pnAfternoon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnAfternoon.Name = "pnAfternoon";
            this.pnAfternoon.Size = new System.Drawing.Size(47, 37);
            this.pnAfternoon.TabIndex = 1;
            this.pnAfternoon.Click += new System.EventHandler(this.pnAfternoon_Click);
            // 
            // pnMorning
            // 
            this.pnMorning.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMorning.Location = new System.Drawing.Point(0, 25);
            this.pnMorning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMorning.Name = "pnMorning";
            this.pnMorning.Size = new System.Drawing.Size(47, 37);
            this.pnMorning.TabIndex = 2;
            this.pnMorning.Click += new System.EventHandler(this.pnMorning_Click);
            // 
            // DateTimeSheetUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAfternoon);
            this.Controls.Add(this.pnMorning);
            this.Controls.Add(this.pnText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DateTimeSheetUC";
            this.Size = new System.Drawing.Size(93, 62);
            this.pnText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnAfternoon;
        private System.Windows.Forms.Panel pnMorning;
    }
}
