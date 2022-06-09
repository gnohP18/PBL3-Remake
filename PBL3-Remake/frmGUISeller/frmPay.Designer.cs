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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtAllCollabTable = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblToPoint = new System.Windows.Forms.Label();
            this.lblToMoney = new System.Windows.Forms.Label();
            this.cbbConvert = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuestMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPayment.GridColor = System.Drawing.Color.White;
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPayment.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.dgvPayment.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(400, 414);
            this.dgvPayment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voucher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVoucher
            // 
            this.txtVoucher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVoucher.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(410, 38);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(275, 29);
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
            this.txtGuestMoney.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestMoney.Location = new System.Drawing.Point(410, 379);
            this.txtGuestMoney.Name = "txtGuestMoney";
            this.txtGuestMoney.Size = new System.Drawing.Size(275, 29);
            this.txtGuestMoney.TabIndex = 8;
            this.txtGuestMoney.TextChanged += new System.EventHandler(this.txtGuestMoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label4.Location = new System.Drawing.Point(430, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guest money";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label5.Location = new System.Drawing.Point(406, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label6.Location = new System.Drawing.Point(462, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "5%=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblTax.Location = new System.Drawing.Point(520, 105);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(254, 35);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "B";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label7.Location = new System.Drawing.Point(412, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Collab Table";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAllCollabTable
            // 
            this.txtAllCollabTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAllCollabTable.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllCollabTable.Location = new System.Drawing.Point(537, 143);
            this.txtAllCollabTable.Name = "txtAllCollabTable";
            this.txtAllCollabTable.Size = new System.Drawing.Size(250, 29);
            this.txtAllCollabTable.TabIndex = 18;
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGuestPhone.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestPhone.Location = new System.Drawing.Point(583, 182);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(204, 29);
            this.txtGuestPhone.TabIndex = 19;
            this.txtGuestPhone.TextChanged += new System.EventHandler(this.txtGuestPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label8.Location = new System.Drawing.Point(406, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Guest information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label9.Location = new System.Drawing.Point(406, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Point";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblPoint.Location = new System.Drawing.Point(473, 220);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(24, 23);
            this.lblPoint.TabIndex = 23;
            this.lblPoint.Text = "D";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBCheckGuest
            // 
            this.pBCheckGuest.Location = new System.Drawing.Point(797, 187);
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
            this.btnYes.Location = new System.Drawing.Point(797, 142);
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
            this.btnVoucherConfirm.Location = new System.Drawing.Point(691, 34);
            this.btnVoucherConfirm.Name = "btnVoucherConfirm";
            this.btnVoucherConfirm.Size = new System.Drawing.Size(33, 33);
            this.btnVoucherConfirm.TabIndex = 13;
            this.btnVoucherConfirm.UseVisualStyleBackColor = true;
            this.btnVoucherConfirm.Click += new System.EventHandler(this.btnVoucherConfirm_Click);
            // 
            // pBGuestMoney
            // 
            this.pBGuestMoney.Location = new System.Drawing.Point(692, 379);
            this.pBGuestMoney.Name = "pBGuestMoney";
            this.pBGuestMoney.Size = new System.Drawing.Size(32, 32);
            this.pBGuestMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGuestMoney.TabIndex = 12;
            this.pBGuestMoney.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_Remake.Properties.Resources.Tax_48;
            this.pictureBox2.Location = new System.Drawing.Point(410, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pBVoucher
            // 
            this.pBVoucher.Location = new System.Drawing.Point(497, 8);
            this.pBVoucher.Name = "pBVoucher";
            this.pBVoucher.Size = new System.Drawing.Size(24, 24);
            this.pBVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVoucher.TabIndex = 6;
            this.pBVoucher.TabStop = false;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label10.Location = new System.Drawing.Point(406, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Convert to point";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.label11.Location = new System.Drawing.Point(406, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Convert to money";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToPoint
            // 
            this.lblToPoint.AutoSize = true;
            this.lblToPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToPoint.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblToPoint.Location = new System.Drawing.Point(579, 256);
            this.lblToPoint.Name = "lblToPoint";
            this.lblToPoint.Size = new System.Drawing.Size(20, 23);
            this.lblToPoint.TabIndex = 26;
            this.lblToPoint.Text = "E";
            this.lblToPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToMoney
            // 
            this.lblToMoney.AutoSize = true;
            this.lblToMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToMoney.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.lblToMoney.Location = new System.Drawing.Point(579, 293);
            this.lblToMoney.Name = "lblToMoney";
            this.lblToMoney.Size = new System.Drawing.Size(20, 23);
            this.lblToMoney.TabIndex = 27;
            this.lblToMoney.Text = "F";
            this.lblToMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbConvert
            // 
            this.cbbConvert.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbConvert.FormattingEnabled = true;
            this.cbbConvert.Location = new System.Drawing.Point(410, 320);
            this.cbbConvert.Name = "cbbConvert";
            this.cbbConvert.Size = new System.Drawing.Size(189, 28);
            this.cbbConvert.TabIndex = 28;
            // 
            // frmPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(840, 526);
            this.Controls.Add(this.cbbConvert);
            this.Controls.Add(this.lblToMoney);
            this.Controls.Add(this.lblToPoint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pBCheckGuest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.txtAllCollabTable);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label7);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuestMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtAllCollabTable;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pBCheckGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblToPoint;
        private System.Windows.Forms.Label lblToMoney;
        private System.Windows.Forms.ComboBox cbbConvert;
    }
}