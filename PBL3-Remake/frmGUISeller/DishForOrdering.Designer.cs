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
            this.btnDES = new System.Windows.Forms.Button();
            this.btnINC = new System.Windows.Forms.Button();
            this.pBDish = new System.Windows.Forms.PictureBox();
            this.lblNameDish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBDish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDES
            // 
            this.btnDES.FlatAppearance.BorderSize = 0;
            this.btnDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDES.Location = new System.Drawing.Point(134, 73);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(33, 33);
            this.btnDES.TabIndex = 2;
            this.btnDES.UseVisualStyleBackColor = true;
            // 
            // btnINC
            // 
            this.btnINC.FlatAppearance.BorderSize = 0;
            this.btnINC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINC.Location = new System.Drawing.Point(134, 22);
            this.btnINC.Name = "btnINC";
            this.btnINC.Size = new System.Drawing.Size(33, 33);
            this.btnINC.TabIndex = 1;
            this.btnINC.UseVisualStyleBackColor = true;
            // 
            // pBDish
            // 
            this.pBDish.Location = new System.Drawing.Point(0, 0);
            this.pBDish.Name = "pBDish";
            this.pBDish.Size = new System.Drawing.Size(128, 128);
            this.pBDish.TabIndex = 0;
            this.pBDish.TabStop = false;
            // 
            // lblNameDish
            // 
            this.lblNameDish.AutoSize = true;
            this.lblNameDish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDish.ForeColor = System.Drawing.Color.Black;
            this.lblNameDish.Location = new System.Drawing.Point(5, 138);
            this.lblNameDish.Name = "lblNameDish";
            this.lblNameDish.Size = new System.Drawing.Size(24, 23);
            this.lblNameDish.TabIndex = 15;
            this.lblNameDish.Text = "A";
            // 
            // DishForOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.lblNameDish);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.btnINC);
            this.Controls.Add(this.pBDish);
            this.Name = "DishForOrdering";
            this.Size = new System.Drawing.Size(180, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pBDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBDish;
        private System.Windows.Forms.Button btnINC;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Label lblNameDish;
    }
}
