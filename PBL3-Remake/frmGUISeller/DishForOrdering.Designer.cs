namespace PBL3_Remake.frmGUISeller
{
    partial class DishForOrdering
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
            this.lblNameDish = new System.Windows.Forms.Label();
            this.pBDish = new System.Windows.Forms.PictureBox();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBDish)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameDish
            // 
            this.lblNameDish.AutoSize = true;
            this.lblNameDish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDish.ForeColor = System.Drawing.Color.Black;
            this.lblNameDish.Location = new System.Drawing.Point(5, 130);
            this.lblNameDish.Name = "lblNameDish";
            this.lblNameDish.Size = new System.Drawing.Size(24, 23);
            this.lblNameDish.TabIndex = 15;
            this.lblNameDish.Text = "A";
            // 
            // pBDish
            // 
            this.pBDish.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBDish.Location = new System.Drawing.Point(0, 0);
            this.pBDish.Name = "pBDish";
            this.pBDish.Size = new System.Drawing.Size(180, 128);
            this.pBDish.TabIndex = 0;
            this.pBDish.TabStop = false;
            this.pBDish.Click += new System.EventHandler(this.pBDish_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Black;
            this.lblCost.Location = new System.Drawing.Point(6, 153);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(24, 23);
            this.lblCost.TabIndex = 16;
            this.lblCost.Text = "B";
            // 
            // DishForOrdering
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblNameDish);
            this.Controls.Add(this.pBDish);
            this.Name = "DishForOrdering";
            this.Size = new System.Drawing.Size(180, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pBDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBDish;
        private System.Windows.Forms.Label lblNameDish;
        private System.Windows.Forms.Label lblCost;
    }
}
