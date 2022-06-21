namespace GUI.frmGUISeller
{
    partial class frmPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtGuestMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.pBCheckGuest = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnPayReceipt = new System.Windows.Forms.Button();
            this.btnVoucherConfirm = new System.Windows.Forms.Button();
            this.pBGuestMoney = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBVoucher = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbUsePoint = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuestMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Controls.Add(this.dgvPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 526);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3_Remake.Properties.Resources.money_48;
            this.pictureBox1.Location = new System.Drawing.Point(76, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(330, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBill
            // 
            this.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(118)))));
            this.lblBill.Location = new System.Drawing.Point(130, 472);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(267, 48);
            this.lblBill.TabIndex = 3;
            this.lblBill.Text = "A";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPayment
            // 
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPayment.GridColor = System.Drawing.Color.White;
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.dgvPayment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(400, 414);
            this.dgvPayment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(412, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voucher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVoucher
            // 
            this.txtVoucher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVoucher.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(509, 16);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(120, 20);
            this.txtVoucher.TabIndex = 7;
            this.txtVoucher.TextChanged += new System.EventHandler(this.txtVoucher_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label3.Location = new System.Drawing.Point(748, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(563, 472);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(267, 48);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "C";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGuestMoney
            // 
            this.txtGuestMoney.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGuestMoney.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestMoney.Location = new System.Drawing.Point(410, 379);
            this.txtGuestMoney.Name = "txtGuestMoney";
            this.txtGuestMoney.Size = new System.Drawing.Size(275, 20);
            this.txtGuestMoney.TabIndex = 8;
            this.txtGuestMoney.TextChanged += new System.EventHandler(this.txtGuestMoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label4.Location = new System.Drawing.Point(406, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guest money";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label5.Location = new System.Drawing.Point(412, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label6.Location = new System.Drawing.Point(462, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "5%=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTax.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblTax.Location = new System.Drawing.Point(503, 72);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(254, 35);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "B";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGuestPhone.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestPhone.Location = new System.Drawing.Point(553, 130);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(204, 20);
            this.txtGuestPhone.TabIndex = 19;
            this.txtGuestPhone.TextChanged += new System.EventHandler(this.txtGuestPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label8.Location = new System.Drawing.Point(406, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Guest information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label9.Location = new System.Drawing.Point(404, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Point";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPoint.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblPoint.Location = new System.Drawing.Point(475, 185);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(21, 19);
            this.lblPoint.TabIndex = 23;
            this.lblPoint.Text = "D";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBCheckGuest
            // 
            this.pBCheckGuest.Location = new System.Drawing.Point(763, 128);
            this.pBCheckGuest.Name = "pBCheckGuest";
            this.pBCheckGuest.Size = new System.Drawing.Size(24, 24);
            this.pBCheckGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCheckGuest.TabIndex = 21;
            this.pBCheckGuest.TabStop = false;
            this.pBCheckGuest.Click += new System.EventHandler(this.pBCheckGuest_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Image = global::PBL3_Remake.Properties.Resources.checkedGreen;
            this.btnYes.Location = new System.Drawing.Point(797, 162);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(33, 33);
            this.btnYes.TabIndex = 16;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnPayReceipt
            // 
            this.btnPayReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.btnPayReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayReceipt.Image = global::PBL3_Remake.Properties.Resources.receipt_32;
            this.btnPayReceipt.Location = new System.Drawing.Point(509, 472);
            this.btnPayReceipt.Name = "btnPayReceipt";
            this.btnPayReceipt.Size = new System.Drawing.Size(48, 48);
            this.btnPayReceipt.TabIndex = 14;
            this.btnPayReceipt.UseVisualStyleBackColor = true;
            this.btnPayReceipt.Click += new System.EventHandler(this.btnPayReceipt_Click);
            // 
            // btnVoucherConfirm
            // 
            this.btnVoucherConfirm.FlatAppearance.BorderSize = 0;
            this.btnVoucherConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherConfirm.Image = global::PBL3_Remake.Properties.Resources.coupon_32;
            this.btnVoucherConfirm.Location = new System.Drawing.Point(635, 10);
            this.btnVoucherConfirm.Name = "btnVoucherConfirm";
            this.btnVoucherConfirm.Size = new System.Drawing.Size(33, 33);
            this.btnVoucherConfirm.TabIndex = 13;
            this.btnVoucherConfirm.UseVisualStyleBackColor = true;
            this.btnVoucherConfirm.Click += new System.EventHandler(this.btnVoucherConfirm_Click);
            // 
            // pBGuestMoney
            // 
            this.pBGuestMoney.Location = new System.Drawing.Point(691, 371);
            this.pBGuestMoney.Name = "pBGuestMoney";
            this.pBGuestMoney.Size = new System.Drawing.Size(32, 32);
            this.pBGuestMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGuestMoney.TabIndex = 12;
            this.pBGuestMoney.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_Remake.Properties.Resources.Tax_48;
            this.pictureBox2.Location = new System.Drawing.Point(408, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pBVoucher
            // 
            this.pBVoucher.Location = new System.Drawing.Point(479, 12);
            this.pBVoucher.Name = "pBVoucher";
            this.pBVoucher.Size = new System.Drawing.Size(24, 24);
            this.pBVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVoucher.TabIndex = 6;
            this.pBVoucher.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label11.Location = new System.Drawing.Point(436, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Use points";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUsePoint
            // 
            this.cbUsePoint.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.cbUsePoint.Image = ((System.Drawing.Image)(resources.GetObject("cbUsePoint.Image")));
            this.cbUsePoint.ImageOffset = new System.Drawing.Point(0, 0);
            this.cbUsePoint.ImageRotate = 0F;
            this.cbUsePoint.ImageSize = new System.Drawing.Size(32, 32);
            this.cbUsePoint.Location = new System.Drawing.Point(406, 219);
            this.cbUsePoint.Name = "cbUsePoint";
            this.cbUsePoint.Size = new System.Drawing.Size(24, 24);
            this.cbUsePoint.TabIndex = 26;
            // 
            // frmPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(840, 526);
            this.Controls.Add(this.cbUsePoint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pBCheckGuest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnPayReceipt);
            this.Controls.Add(this.btnVoucherConfirm);
            this.Controls.Add(this.pBGuestMoney);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuestMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pBVoucher);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPay";
            this.Text = "frmPay";
            this.Load += new System.EventHandler(this.frmPay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuestMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.PictureBox pBVoucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtGuestMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pBGuestMoney;
        private System.Windows.Forms.Button btnVoucherConfirm;
        private System.Windows.Forms.Button btnPayReceipt;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pBCheckGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbUsePoint;
    }
}