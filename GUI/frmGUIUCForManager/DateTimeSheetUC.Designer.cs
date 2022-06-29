namespace GUI.frmGUIUCForManager
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
            this.pnAfternoon = new System.Windows.Forms.Panel();
            this.pnMorning = new System.Windows.Forms.Panel();
            this.btnDate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnText.Controls.Add(this.btnDate);
            this.pnText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnText.Location = new System.Drawing.Point(0, 0);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(70, 20);
            this.pnText.TabIndex = 0;
            // 
            // pnAfternoon
            // 
            this.pnAfternoon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAfternoon.Location = new System.Drawing.Point(35, 20);
            this.pnAfternoon.Name = "pnAfternoon";
            this.pnAfternoon.Size = new System.Drawing.Size(35, 30);
            this.pnAfternoon.TabIndex = 1;
            this.pnAfternoon.Click += new System.EventHandler(this.pnAfternoon_Click);
            // 
            // pnMorning
            // 
            this.pnMorning.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMorning.Location = new System.Drawing.Point(0, 20);
            this.pnMorning.Name = "pnMorning";
            this.pnMorning.Size = new System.Drawing.Size(35, 30);
            this.pnMorning.TabIndex = 2;
            this.pnMorning.Click += new System.EventHandler(this.pnMorning_Click);
            // 
            // btnDate
            // 
            this.btnDate.BorderRadius = 5;
            this.btnDate.BorderThickness = 1;
            this.btnDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDate.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.Black;
            this.btnDate.Location = new System.Drawing.Point(0, 0);
            this.btnDate.Name = "btnDate";
            this.btnDate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDate.PressedDepth = 80;
            this.btnDate.Size = new System.Drawing.Size(70, 20);
            this.btnDate.TabIndex = 20;
            this.btnDate.Text = "abc";
            // 
            // DateTimeSheetUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAfternoon);
            this.Controls.Add(this.pnMorning);
            this.Controls.Add(this.pnText);
            this.Name = "DateTimeSheetUC";
            this.Size = new System.Drawing.Size(70, 50);
            this.pnText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnText;
        private System.Windows.Forms.Panel pnAfternoon;
        private System.Windows.Forms.Panel pnMorning;
        private Guna.UI2.WinForms.Guna2GradientButton btnDate;
    }
}
