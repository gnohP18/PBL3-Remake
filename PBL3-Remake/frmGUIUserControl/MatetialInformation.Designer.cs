namespace GUI.frmGUIUserControl
{
    partial class MatetialInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatetialInformation));
            this.btClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.btnVegetable = new System.Windows.Forms.Button();
            this.btnDriedFood = new System.Windows.Forms.Button();
            this.btnFreshFood = new System.Windows.Forms.Button();
            this.btnDrinking = new System.Windows.Forms.Button();
            this.btnAllMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(530, 527);
            this.btClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(166, 24);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "CLose";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(273, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Matetial Information";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(11, 132);
            this.dgvNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(685, 387);
            this.dgvNguyenLieu.TabIndex = 38;
            // 
            // btnVegetable
            // 
            this.btnVegetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnVegetable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnVegetable.FlatAppearance.BorderSize = 2;
            this.btnVegetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVegetable.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVegetable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnVegetable.Image = ((System.Drawing.Image)(resources.GetObject("btnVegetable.Image")));
            this.btnVegetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVegetable.Location = new System.Drawing.Point(425, 48);
            this.btnVegetable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVegetable.Name = "btnVegetable";
            this.btnVegetable.Size = new System.Drawing.Size(140, 62);
            this.btnVegetable.TabIndex = 3;
            this.btnVegetable.Text = "Vegetable";
            this.btnVegetable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVegetable.UseVisualStyleBackColor = false;
            this.btnVegetable.Click += new System.EventHandler(this.btnVegetable_Click);
            // 
            // btnDriedFood
            // 
            this.btnDriedFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnDriedFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnDriedFood.FlatAppearance.BorderSize = 2;
            this.btnDriedFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDriedFood.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriedFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.btnDriedFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDriedFood.Image")));
            this.btnDriedFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriedFood.Location = new System.Drawing.Point(143, 48);
            this.btnDriedFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDriedFood.Name = "btnDriedFood";
            this.btnDriedFood.Size = new System.Drawing.Size(140, 62);
            this.btnDriedFood.TabIndex = 1;
            this.btnDriedFood.Text = "Dried Food";
            this.btnDriedFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDriedFood.UseVisualStyleBackColor = false;
            this.btnDriedFood.Click += new System.EventHandler(this.btnDriedFood_Click);
            // 
            // btnFreshFood
            // 
            this.btnFreshFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnFreshFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnFreshFood.FlatAppearance.BorderSize = 2;
            this.btnFreshFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFreshFood.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreshFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.btnFreshFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFreshFood.Image")));
            this.btnFreshFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreshFood.Location = new System.Drawing.Point(287, 48);
            this.btnFreshFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFreshFood.Name = "btnFreshFood";
            this.btnFreshFood.Size = new System.Drawing.Size(140, 62);
            this.btnFreshFood.TabIndex = 2;
            this.btnFreshFood.Text = "Fresh Food";
            this.btnFreshFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFreshFood.UseVisualStyleBackColor = false;
            this.btnFreshFood.Click += new System.EventHandler(this.btnFreshFood_Click);
            // 
            // btnDrinking
            // 
            this.btnDrinking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnDrinking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnDrinking.FlatAppearance.BorderSize = 2;
            this.btnDrinking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrinking.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnDrinking.Image = ((System.Drawing.Image)(resources.GetObject("btnDrinking.Image")));
            this.btnDrinking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinking.Location = new System.Drawing.Point(556, 48);
            this.btnDrinking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrinking.Name = "btnDrinking";
            this.btnDrinking.Size = new System.Drawing.Size(140, 62);
            this.btnDrinking.TabIndex = 4;
            this.btnDrinking.Text = "Drinking";
            this.btnDrinking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrinking.UseVisualStyleBackColor = false;
            this.btnDrinking.Click += new System.EventHandler(this.btnDrinking_Click);
            // 
            // btnAllMaterial
            // 
            this.btnAllMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAllMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAllMaterial.FlatAppearance.BorderSize = 2;
            this.btnAllMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllMaterial.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.btnAllMaterial.Location = new System.Drawing.Point(11, 48);
            this.btnAllMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAllMaterial.Name = "btnAllMaterial";
            this.btnAllMaterial.Size = new System.Drawing.Size(128, 62);
            this.btnAllMaterial.TabIndex = 0;
            this.btnAllMaterial.Text = "All Material";
            this.btnAllMaterial.UseVisualStyleBackColor = false;
            this.btnAllMaterial.Click += new System.EventHandler(this.btnAllMaterial_Click);
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnUpdateMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateMaterial.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMaterial.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMaterial.Location = new System.Drawing.Point(181, 527);
            this.btnUpdateMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(166, 24);
            this.btnUpdateMaterial.TabIndex = 6;
            this.btnUpdateMaterial.Text = "Update material";
            this.btnUpdateMaterial.UseVisualStyleBackColor = false;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.btnUpdateMaterial_Click);
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnAddNewMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewMaterial.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMaterial.Location = new System.Drawing.Point(11, 527);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(166, 24);
            this.btnAddNewMaterial.TabIndex = 5;
            this.btnAddNewMaterial.Text = "Add new material";
            this.btnAddNewMaterial.UseVisualStyleBackColor = false;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.btnDeleteMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(351, 527);
            this.btnDeleteMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(166, 24);
            this.btnDeleteMaterial.TabIndex = 7;
            this.btnDeleteMaterial.Text = "Delete material";
            this.btnDeleteMaterial.UseVisualStyleBackColor = false;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // MatetialInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(707, 562);
            this.Controls.Add(this.btnVegetable);
            this.Controls.Add(this.btnAllMaterial);
            this.Controls.Add(this.btnDriedFood);
            this.Controls.Add(this.btnFreshFood);
            this.Controls.Add(this.btnDrinking);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.btnUpdateMaterial);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvNguyenLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MatetialInformation";
            this.Text = "DetailMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Button btnVegetable;
        private System.Windows.Forms.Button btnDriedFood;
        private System.Windows.Forms.Button btnFreshFood;
        private System.Windows.Forms.Button btnDrinking;
        private System.Windows.Forms.Button btnAllMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
    }
}