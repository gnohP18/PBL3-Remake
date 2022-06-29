namespace GUI.frmGUIUCForManager
{
    partial class WareHouseUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtAmountFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMoreInfor = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMaterialInformation = new System.Windows.Forms.Button();
            this.btnViewExpiredMaterial = new System.Windows.Forms.Button();
            this.btnAddMaterialToWareHouse = new System.Windows.Forms.Button();
            this.btnAllMaterial = new System.Windows.Forms.Button();
            this.btnVegetable = new System.Windows.Forms.Button();
            this.btnDriedFood = new System.Windows.Forms.Button();
            this.btnFreshFood = new System.Windows.Forms.Button();
            this.btnDrinking = new System.Windows.Forms.Button();
            this.dgvNguyenLieuKho = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(2, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(71, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 30);
            this.label13.TabIndex = 16;
            this.label13.Text = "Material Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvNguyenLieuKho);
            this.panel5.Location = new System.Drawing.Point(4, 144);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 539);
            this.panel5.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(3, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 26);
            this.label15.TabIndex = 18;
            this.label15.Text = "Amount";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtAmountFood);
            this.panel6.Controls.Add(this.txtNameFood);
            this.panel6.Controls.Add(this.btnMoreInfor);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(869, 11);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(327, 125);
            this.panel6.TabIndex = 23;
            // 
            // txtAmountFood
            // 
            this.txtAmountFood.AutoRoundedCorners = true;
            this.txtAmountFood.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtAmountFood.BorderRadius = 14;
            this.txtAmountFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountFood.DefaultText = "";
            this.txtAmountFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmountFood.ForeColor = System.Drawing.Color.Black;
            this.txtAmountFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountFood.Location = new System.Drawing.Point(75, 81);
            this.txtAmountFood.Name = "txtAmountFood";
            this.txtAmountFood.PasswordChar = '\0';
            this.txtAmountFood.PlaceholderText = "";
            this.txtAmountFood.SelectedText = "";
            this.txtAmountFood.Size = new System.Drawing.Size(190, 30);
            this.txtAmountFood.TabIndex = 24;
            // 
            // txtNameFood
            // 
            this.txtNameFood.AutoRoundedCorners = true;
            this.txtNameFood.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNameFood.BorderRadius = 14;
            this.txtNameFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameFood.DefaultText = "";
            this.txtNameFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameFood.ForeColor = System.Drawing.Color.Black;
            this.txtNameFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFood.Location = new System.Drawing.Point(75, 39);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.PasswordChar = '\0';
            this.txtNameFood.PlaceholderText = "";
            this.txtNameFood.SelectedText = "";
            this.txtNameFood.Size = new System.Drawing.Size(190, 30);
            this.txtNameFood.TabIndex = 23;
            // 
            // btnMoreInfor
            // 
            this.btnMoreInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoreInfor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreInfor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMoreInfor.Location = new System.Drawing.Point(265, 85);
            this.btnMoreInfor.Name = "btnMoreInfor";
            this.btnMoreInfor.Size = new System.Drawing.Size(60, 22);
            this.btnMoreInfor.TabIndex = 20;
            this.btnMoreInfor.Text = "More";
            this.btnMoreInfor.UseVisualStyleBackColor = false;
            this.btnMoreInfor.Click += new System.EventHandler(this.btnMoreInfor_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnMaterialInformation);
            this.panel7.Controls.Add(this.btnViewExpiredMaterial);
            this.panel7.Controls.Add(this.btnAddMaterialToWareHouse);
            this.panel7.Location = new System.Drawing.Point(1020, 145);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(176, 538);
            this.panel7.TabIndex = 24;
            // 
            // btnMaterialInformation
            // 
            this.btnMaterialInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaterialInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnMaterialInformation.FlatAppearance.BorderSize = 2;
            this.btnMaterialInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaterialInformation.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnMaterialInformation.Image = global::GUI.Properties.Resources.ingredients_64;
            this.btnMaterialInformation.Location = new System.Drawing.Point(0, 369);
            this.btnMaterialInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterialInformation.Name = "btnMaterialInformation";
            this.btnMaterialInformation.Size = new System.Drawing.Size(174, 167);
            this.btnMaterialInformation.TabIndex = 15;
            this.btnMaterialInformation.Text = "Material information";
            this.btnMaterialInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterialInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaterialInformation.UseVisualStyleBackColor = false;
            this.btnMaterialInformation.Click += new System.EventHandler(this.btnMaterialInformation_Click);
            // 
            // btnViewExpiredMaterial
            // 
            this.btnViewExpiredMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnViewExpiredMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewExpiredMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnViewExpiredMaterial.FlatAppearance.BorderSize = 2;
            this.btnViewExpiredMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewExpiredMaterial.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExpiredMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnViewExpiredMaterial.Image = global::GUI.Properties.Resources.expired_food_64;
            this.btnViewExpiredMaterial.Location = new System.Drawing.Point(0, 176);
            this.btnViewExpiredMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewExpiredMaterial.Name = "btnViewExpiredMaterial";
            this.btnViewExpiredMaterial.Size = new System.Drawing.Size(174, 193);
            this.btnViewExpiredMaterial.TabIndex = 15;
            this.btnViewExpiredMaterial.Text = "View Expired Material";
            this.btnViewExpiredMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewExpiredMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewExpiredMaterial.UseVisualStyleBackColor = false;
            this.btnViewExpiredMaterial.Click += new System.EventHandler(this.btnViewExpiredMaterial_Click);
            // 
            // btnAddMaterialToWareHouse
            // 
            this.btnAddMaterialToWareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAddMaterialToWareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMaterialToWareHouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAddMaterialToWareHouse.FlatAppearance.BorderSize = 2;
            this.btnAddMaterialToWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMaterialToWareHouse.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterialToWareHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnAddMaterialToWareHouse.Image = global::GUI.Properties.Resources.add_to_basket_64;
            this.btnAddMaterialToWareHouse.Location = new System.Drawing.Point(0, 0);
            this.btnAddMaterialToWareHouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMaterialToWareHouse.Name = "btnAddMaterialToWareHouse";
            this.btnAddMaterialToWareHouse.Size = new System.Drawing.Size(174, 176);
            this.btnAddMaterialToWareHouse.TabIndex = 15;
            this.btnAddMaterialToWareHouse.Text = "Add Material To WareHouse";
            this.btnAddMaterialToWareHouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMaterialToWareHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMaterialToWareHouse.UseVisualStyleBackColor = false;
            this.btnAddMaterialToWareHouse.Click += new System.EventHandler(this.btnAddMaterialToWareHouse_Click);
            // 
            // btnAllMaterial
            // 
            this.btnAllMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAllMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAllMaterial.FlatAppearance.BorderSize = 2;
            this.btnAllMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllMaterial.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.btnAllMaterial.Location = new System.Drawing.Point(677, 10);
            this.btnAllMaterial.Name = "btnAllMaterial";
            this.btnAllMaterial.Size = new System.Drawing.Size(169, 125);
            this.btnAllMaterial.TabIndex = 29;
            this.btnAllMaterial.Text = "All Material";
            this.btnAllMaterial.UseVisualStyleBackColor = false;
            this.btnAllMaterial.Click += new System.EventHandler(this.btnAllMaterial_Click);
            // 
            // btnVegetable
            // 
            this.btnVegetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnVegetable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnVegetable.FlatAppearance.BorderSize = 2;
            this.btnVegetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVegetable.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVegetable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnVegetable.Image = ((System.Drawing.Image)(resources.GetObject("btnVegetable.Image")));
            this.btnVegetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVegetable.Location = new System.Drawing.Point(344, 10);
            this.btnVegetable.Name = "btnVegetable";
            this.btnVegetable.Size = new System.Drawing.Size(170, 125);
            this.btnVegetable.TabIndex = 27;
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
            this.btnDriedFood.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriedFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.btnDriedFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDriedFood.Image")));
            this.btnDriedFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriedFood.Location = new System.Drawing.Point(4, 10);
            this.btnDriedFood.Name = "btnDriedFood";
            this.btnDriedFood.Size = new System.Drawing.Size(170, 125);
            this.btnDriedFood.TabIndex = 25;
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
            this.btnFreshFood.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreshFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.btnFreshFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFreshFood.Image")));
            this.btnFreshFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreshFood.Location = new System.Drawing.Point(174, 10);
            this.btnFreshFood.Name = "btnFreshFood";
            this.btnFreshFood.Size = new System.Drawing.Size(170, 125);
            this.btnFreshFood.TabIndex = 26;
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
            this.btnDrinking.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnDrinking.Image = ((System.Drawing.Image)(resources.GetObject("btnDrinking.Image")));
            this.btnDrinking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinking.Location = new System.Drawing.Point(514, 10);
            this.btnDrinking.Name = "btnDrinking";
            this.btnDrinking.Size = new System.Drawing.Size(170, 125);
            this.btnDrinking.TabIndex = 28;
            this.btnDrinking.Text = "Drinking";
            this.btnDrinking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrinking.UseVisualStyleBackColor = false;
            this.btnDrinking.Click += new System.EventHandler(this.btnDrinking_Click);
            // 
            // dgvNguyenLieuKho
            // 
            this.dgvNguyenLieuKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieuKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNguyenLieuKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieuKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguyenLieuKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguyenLieuKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguyenLieuKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenLieuKho.EnableHeadersVisualStyles = false;
            this.dgvNguyenLieuKho.GridColor = System.Drawing.Color.White;
            this.dgvNguyenLieuKho.Location = new System.Drawing.Point(0, 0);
            this.dgvNguyenLieuKho.MultiSelect = false;
            this.dgvNguyenLieuKho.Name = "dgvNguyenLieuKho";
            this.dgvNguyenLieuKho.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieuKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguyenLieuKho.RowHeadersVisible = false;
            this.dgvNguyenLieuKho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            this.dgvNguyenLieuKho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNguyenLieuKho.RowTemplate.Height = 24;
            this.dgvNguyenLieuKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieuKho.Size = new System.Drawing.Size(1006, 537);
            this.dgvNguyenLieuKho.TabIndex = 2;
            this.dgvNguyenLieuKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieuKho_CellClick);
            // 
            // WareHouseUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.btnAllMaterial);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnVegetable);
            this.Controls.Add(this.btnDriedFood);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnFreshFood);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnDrinking);
            this.Name = "WareHouseUC";
            this.Size = new System.Drawing.Size(1200, 700);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVegetable;
        private System.Windows.Forms.Button btnDriedFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMoreInfor;
        private System.Windows.Forms.Button btnFreshFood;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDrinking;
        private System.Windows.Forms.Button btnAddMaterialToWareHouse;
        private System.Windows.Forms.Button btnViewExpiredMaterial;
        private System.Windows.Forms.Button btnMaterialInformation;
        private System.Windows.Forms.Button btnAllMaterial;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountFood;
        private Guna.UI2.WinForms.Guna2TextBox txtNameFood;
        private System.Windows.Forms.DataGridView dgvNguyenLieuKho;
    }
}
