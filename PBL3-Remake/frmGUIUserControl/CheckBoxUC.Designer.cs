namespace GUI.frmGUIUserControl
{
    partial class CheckBoxUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBoxUC));
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.picUnchecked = new System.Windows.Forms.PictureBox();
            this.lbMess1 = new System.Windows.Forms.Label();
            this.lbMess2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnchecked)).BeginInit();
            this.SuspendLayout();
            // 
            // picCheck
            // 
            this.picCheck.Image = ((System.Drawing.Image)(resources.GetObject("picCheck.Image")));
            this.picCheck.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCheck.InitialImage")));
            this.picCheck.Location = new System.Drawing.Point(12, 12);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(48, 48);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 0;
            this.picCheck.TabStop = false;
            this.picCheck.Click += new System.EventHandler(this.picCheck_Click);
            // 
            // picUnchecked
            // 
            this.picUnchecked.Image = ((System.Drawing.Image)(resources.GetObject("picUnchecked.Image")));
            this.picUnchecked.InitialImage = ((System.Drawing.Image)(resources.GetObject("picUnchecked.InitialImage")));
            this.picUnchecked.Location = new System.Drawing.Point(16, 13);
            this.picUnchecked.Name = "picUnchecked";
            this.picUnchecked.Size = new System.Drawing.Size(44, 44);
            this.picUnchecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnchecked.TabIndex = 1;
            this.picUnchecked.TabStop = false;
            this.picUnchecked.Click += new System.EventHandler(this.picCheck_Click);
            // 
            // lbMess1
            // 
            this.lbMess1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(81)))), ((int)(((byte)(128)))));
            this.lbMess1.Location = new System.Drawing.Point(92, 0);
            this.lbMess1.Name = "lbMess1";
            this.lbMess1.Size = new System.Drawing.Size(544, 43);
            this.lbMess1.TabIndex = 2;
            this.lbMess1.Text = "abc";
            this.lbMess1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMess1.Click += new System.EventHandler(this.picCheck_Click);
            // 
            // lbMess2
            // 
            this.lbMess2.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(81)))), ((int)(((byte)(128)))));
            this.lbMess2.Location = new System.Drawing.Point(92, 43);
            this.lbMess2.Name = "lbMess2";
            this.lbMess2.Size = new System.Drawing.Size(544, 43);
            this.lbMess2.TabIndex = 2;
            this.lbMess2.Text = "abc";
            this.lbMess2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMess2.Click += new System.EventHandler(this.picCheck_Click);
            // 
            // CheckBoxUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMess2);
            this.Controls.Add(this.lbMess1);
            this.Controls.Add(this.picUnchecked);
            this.Controls.Add(this.picCheck);
            this.Name = "CheckBoxUC";
            this.Size = new System.Drawing.Size(636, 86);
            this.Click += new System.EventHandler(this.picCheck_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnchecked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.PictureBox picUnchecked;
        private System.Windows.Forms.Label lbMess1;
        private System.Windows.Forms.Label lbMess2;
    }
}
