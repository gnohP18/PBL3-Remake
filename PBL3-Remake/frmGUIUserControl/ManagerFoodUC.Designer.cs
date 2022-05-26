namespace GUI.frmGUIUserControl
{
    partial class ManagerFoodUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnMainDish = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnFood = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnDessert);
            this.panel1.Controls.Add(this.btnMainDish);
            this.panel1.Controls.Add(this.btnAppetizer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAll.Image = global::PBL3_Remake.Properties.Resources.diet_32;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(11, 7);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAll.Size = new System.Drawing.Size(145, 50);
            this.btnAll.TabIndex = 29;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Image = global::PBL3_Remake.Properties.Resources.add_64;
            this.btnAddFood.Location = new System.Drawing.Point(1100, 0);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 70);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::PBL3_Remake.Properties.Resources.poinsettia_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(591, 7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "Beverages";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnDessert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDessert.Image = global::PBL3_Remake.Properties.Resources.piece_of_cake_32;
            this.btnDessert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.Location = new System.Drawing.Point(446, 7);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDessert.Size = new System.Drawing.Size(145, 50);
            this.btnDessert.TabIndex = 27;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnMainDish
            // 
            this.btnMainDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMainDish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.btnMainDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDish.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDish.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMainDish.Image = global::PBL3_Remake.Properties.Resources.cooking_32;
            this.btnMainDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDish.Location = new System.Drawing.Point(301, 7);
            this.btnMainDish.Name = "btnMainDish";
            this.btnMainDish.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMainDish.Size = new System.Drawing.Size(145, 50);
            this.btnMainDish.TabIndex = 26;
            this.btnMainDish.Text = "MainDish";
            this.btnMainDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainDish.UseVisualStyleBackColor = false;
            this.btnMainDish.Click += new System.EventHandler(this.btnMainDish_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAppetizer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(253)))));
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAppetizer.Image = global::PBL3_Remake.Properties.Resources.mussel_32;
            this.btnAppetizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.Location = new System.Drawing.Point(156, 7);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAppetizer.Size = new System.Drawing.Size(145, 50);
            this.btnAppetizer.TabIndex = 25;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppetizer.UseVisualStyleBackColor = false;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1100, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 630);
            this.panel2.TabIndex = 1;
            // 
            // pnFood
            // 
            this.pnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.pnFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFood.Location = new System.Drawing.Point(0, 70);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(1100, 630);
            this.pnFood.TabIndex = 2;
            // 
            // ManagerFoodUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerFoodUC";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ManagerFoodUC_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnFood;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnMainDish;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnAll;
    }
}
