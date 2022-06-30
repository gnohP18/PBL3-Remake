namespace GUI.frmGUIUCForManager
{
    partial class FoodInWareHouse
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
            this.btnDetail = new System.Windows.Forms.Button();
            this.pBFood = new System.Windows.Forms.PictureBox();
            this.lblNameFood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Image = global::GUI.Properties.Resources.information_32;
            this.btnDetail.Location = new System.Drawing.Point(164, 114);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(33, 33);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pBFood
            // 
            this.pBFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBFood.Location = new System.Drawing.Point(0, 0);
            this.pBFood.Name = "pBFood";
            this.pBFood.Size = new System.Drawing.Size(200, 112);
            this.pBFood.TabIndex = 0;
            this.pBFood.TabStop = false;
            // 
            // lblNameFood
            // 
            this.lblNameFood.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(3, 119);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(155, 23);
            this.lblNameFood.TabIndex = 2;
            this.lblNameFood.Text = "A";
            // 
            // CoursesInWareHouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblNameFood);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.pBFood);
            this.Name = "CoursesInWareHouse";
            this.Size = new System.Drawing.Size(200, 150);
            this.Load += new System.EventHandler(this.CoursesInWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBFood;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblNameFood;
    }
}
