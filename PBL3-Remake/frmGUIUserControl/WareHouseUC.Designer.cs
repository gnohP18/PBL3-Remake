namespace GUI.frmGUIUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseUC));
            this.txtAmountFood = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvNguyenLieuKho = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMoreInfor = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMaterialInformation = new System.Windows.Forms.Button();
            this.btnViewExpiredMaterial = new System.Windows.Forms.Button();
            this.btnAddMaterialToWareHouse = new System.Windows.Forms.Button();
            this.btnVegetable = new System.Windows.Forms.Button();
            this.btnDriedFood = new System.Windows.Forms.Button();
            this.btnFreshFood = new System.Windows.Forms.Button();
            this.btnDrinking = new System.Windows.Forms.Button();
            this.btnAllMaterial = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuKho)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmountFood
            // 
            this.txtAmountFood.Enabled = false;
            this.txtAmountFood.Location = new System.Drawing.Point(88, 94);
            this.txtAmountFood.Name = "txtAmountFood";
            this.txtAmountFood.Size = new System.Drawing.Size(100, 22);
            this.txtAmountFood.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(2, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(71, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 27);
            this.label13.TabIndex = 16;
            this.label13.Text = "Material Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvNguyenLieuKho);
            this.panel5.Location = new System.Drawing.Point(4, 194);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(842, 460);
            this.panel5.TabIndex = 22;
            // 
            // dgvNguyenLieuKho
            // 
            this.dgvNguyenLieuKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieuKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieuKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguyenLieuKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguyenLieuKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguyenLieuKho.EnableHeadersVisualStyles = false;
            this.dgvNguyenLieuKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.dgvNguyenLieuKho.Location = new System.Drawing.Point(-1, -1);
            this.dgvNguyenLieuKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguyenLieuKho.Name = "dgvNguyenLieuKho";
            this.dgvNguyenLieuKho.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieuKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguyenLieuKho.RowHeadersVisible = false;
            this.dgvNguyenLieuKho.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.dgvNguyenLieuKho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNguyenLieuKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieuKho.Size = new System.Drawing.Size(841, 460);
            this.dgvNguyenLieuKho.TabIndex = 0;
            this.dgvNguyenLieuKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieuKho_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(3, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "Amount";
            // 
            // txtNameFood
            // 
            this.txtNameFood.Enabled = false;
            this.txtNameFood.Location = new System.Drawing.Point(10, 60);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(178, 22);
            this.txtNameFood.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtNameFood);
            this.panel6.Controls.Add(this.btnMoreInfor);
            this.panel6.Controls.Add(this.txtAmountFood);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(869, 48);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(327, 125);
            this.panel6.TabIndex = 23;
            // 
            // btnMoreInfor
            // 
            this.btnMoreInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMoreInfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoreInfor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMoreInfor.Location = new System.Drawing.Point(195, 93);
            this.btnMoreInfor.Name = "btnMoreInfor";
            this.btnMoreInfor.Size = new System.Drawing.Size(96, 22);
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
            this.panel7.Location = new System.Drawing.Point(869, 194);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 460);
            this.panel7.TabIndex = 24;
            // 
            // btnMaterialInformation
            // 
            this.btnMaterialInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnMaterialInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnMaterialInformation.FlatAppearance.BorderSize = 2;
            this.btnMaterialInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaterialInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialInformation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaterialInformation.Location = new System.Drawing.Point(63, 158);
            this.btnMaterialInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterialInformation.Name = "btnMaterialInformation";
            this.btnMaterialInformation.Size = new System.Drawing.Size(180, 45);
            this.btnMaterialInformation.TabIndex = 15;
            this.btnMaterialInformation.Text = "Material information";
            this.btnMaterialInformation.UseVisualStyleBackColor = false;
            this.btnMaterialInformation.Click += new System.EventHandler(this.btnMaterialInformation_Click);
            // 
            // btnViewExpiredMaterial
            // 
            this.btnViewExpiredMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnViewExpiredMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnViewExpiredMaterial.FlatAppearance.BorderSize = 2;
            this.btnViewExpiredMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewExpiredMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExpiredMaterial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewExpiredMaterial.Location = new System.Drawing.Point(63, 236);
            this.btnViewExpiredMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewExpiredMaterial.Name = "btnViewExpiredMaterial";
            this.btnViewExpiredMaterial.Size = new System.Drawing.Size(180, 45);
            this.btnViewExpiredMaterial.TabIndex = 15;
            this.btnViewExpiredMaterial.Text = "ViewExpiredMaterial";
            this.btnViewExpiredMaterial.UseVisualStyleBackColor = false;
            this.btnViewExpiredMaterial.Click += new System.EventHandler(this.btnViewExpiredMaterial_Click);
            // 
            // btnAddMaterialToWareHouse
            // 
            this.btnAddMaterialToWareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAddMaterialToWareHouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAddMaterialToWareHouse.FlatAppearance.BorderSize = 2;
            this.btnAddMaterialToWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMaterialToWareHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterialToWareHouse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMaterialToWareHouse.Location = new System.Drawing.Point(63, 75);
            this.btnAddMaterialToWareHouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMaterialToWareHouse.Name = "btnAddMaterialToWareHouse";
            this.btnAddMaterialToWareHouse.Size = new System.Drawing.Size(180, 45);
            this.btnAddMaterialToWareHouse.TabIndex = 15;
            this.btnAddMaterialToWareHouse.Text = "Add Material To WareHouse";
            this.btnAddMaterialToWareHouse.UseVisualStyleBackColor = false;
            this.btnAddMaterialToWareHouse.Click += new System.EventHandler(this.btnAddMaterialToWareHouse_Click);
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
            this.btnVegetable.Location = new System.Drawing.Point(344, 47);
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
            this.btnDriedFood.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriedFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.btnDriedFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDriedFood.Image")));
            this.btnDriedFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriedFood.Location = new System.Drawing.Point(4, 47);
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
            this.btnFreshFood.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreshFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.btnFreshFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFreshFood.Image")));
            this.btnFreshFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreshFood.Location = new System.Drawing.Point(174, 47);
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
            this.btnDrinking.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnDrinking.Image = ((System.Drawing.Image)(resources.GetObject("btnDrinking.Image")));
            this.btnDrinking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinking.Location = new System.Drawing.Point(514, 47);
            this.btnDrinking.Name = "btnDrinking";
            this.btnDrinking.Size = new System.Drawing.Size(170, 125);
            this.btnDrinking.TabIndex = 28;
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
            this.btnAllMaterial.Location = new System.Drawing.Point(677, 47);
            this.btnAllMaterial.Name = "btnAllMaterial";
            this.btnAllMaterial.Size = new System.Drawing.Size(169, 125);
            this.btnAllMaterial.TabIndex = 29;
            this.btnAllMaterial.Text = "All Material";
            this.btnAllMaterial.UseVisualStyleBackColor = false;
            this.btnAllMaterial.Click += new System.EventHandler(this.btnAllMaterial_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuKho)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountFood;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvNguyenLieuKho;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVegetable;
        private System.Windows.Forms.Button btnDriedFood;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMoreInfor;
        private System.Windows.Forms.Button btnFreshFood;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDrinking;
        private System.Windows.Forms.Button btnAddMaterialToWareHouse;
        private System.Windows.Forms.Button btnViewExpiredMaterial;
        private System.Windows.Forms.Button btnMaterialInformation;
        private System.Windows.Forms.Button btnAllMaterial;
    }
}
