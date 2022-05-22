namespace GUI.frmGUISeller
{
    partial class frmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnDish = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblNameTable = new System.Windows.Forms.Label();
            this.lblIDTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMainDish = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDish
            // 
            this.pnDish.Location = new System.Drawing.Point(3, 68);
            this.pnDish.Name = "pnDish";
            this.pnDish.Size = new System.Drawing.Size(840, 526);
            this.pnDish.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.dgvOrder);
            this.panel2.Location = new System.Drawing.Point(849, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 580);
            this.panel2.TabIndex = 26;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrder.GridColor = System.Drawing.Color.White;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(440, 470);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // lblNameTable
            // 
            this.lblNameTable.AutoSize = true;
            this.lblNameTable.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTable.ForeColor = System.Drawing.Color.White;
            this.lblNameTable.Location = new System.Drawing.Point(683, 36);
            this.lblNameTable.Name = "lblNameTable";
            this.lblNameTable.Size = new System.Drawing.Size(31, 31);
            this.lblNameTable.TabIndex = 27;
            this.lblNameTable.Text = "B";
            // 
            // lblIDTable
            // 
            this.lblIDTable.AutoSize = true;
            this.lblIDTable.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTable.ForeColor = System.Drawing.Color.White;
            this.lblIDTable.Location = new System.Drawing.Point(684, 10);
            this.lblIDTable.Name = "lblIDTable";
            this.lblIDTable.Size = new System.Drawing.Size(27, 26);
            this.lblIDTable.TabIndex = 28;
            this.lblIDTable.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(616, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(616, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1300, 600);
            this.pnMain.TabIndex = 32;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPay.Image = global::PBL3_Remake.Properties.Resources.wallet_64;
            this.btnPay.Location = new System.Drawing.Point(0, 470);
            this.btnPay.Name = "btnPay";
            this.btnPay.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPay.Size = new System.Drawing.Size(220, 110);
            this.btnPay.TabIndex = 32;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Image = global::PBL3_Remake.Properties.Resources.Order_64;
            this.btnOrder.Location = new System.Drawing.Point(220, 470);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 110);
            this.btnOrder.TabIndex = 31;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::PBL3_Remake.Properties.Resources.poinsettia_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(447, 12);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 24;
            this.button2.Text = "Beverages";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::PBL3_Remake.Properties.Resources.piece_of_cake_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Dessert";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainDish
            // 
            this.btnMainDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnMainDish.FlatAppearance.BorderSize = 0;
            this.btnMainDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDish.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDish.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMainDish.Image = global::PBL3_Remake.Properties.Resources.cooking_32;
            this.btnMainDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDish.Location = new System.Drawing.Point(157, 12);
            this.btnMainDish.Name = "btnMainDish";
            this.btnMainDish.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMainDish.Size = new System.Drawing.Size(145, 50);
            this.btnMainDish.TabIndex = 22;
            this.btnMainDish.Text = "MainDish";
            this.btnMainDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainDish.UseVisualStyleBackColor = false;
            this.btnMainDish.Click += new System.EventHandler(this.btnMainDish_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.btnAppetizer.FlatAppearance.BorderSize = 0;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAppetizer.Image = global::PBL3_Remake.Properties.Resources.mussel_32;
            this.btnAppetizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.Location = new System.Drawing.Point(12, 12);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAppetizer.Size = new System.Drawing.Size(145, 50);
            this.btnAppetizer.TabIndex = 21;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppetizer.UseVisualStyleBackColor = false;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIDTable);
            this.Controls.Add(this.lblNameTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnDish);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMainDish);
            this.Controls.Add(this.btnAppetizer);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnMainDish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnDish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblNameTable;
        private System.Windows.Forms.Label lblIDTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnMain;
    }
}