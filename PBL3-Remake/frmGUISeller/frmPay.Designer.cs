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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblNameGuest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGuestMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGuestPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuestMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoucher)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(330, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.GhostWhite;
            this.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.dgvPayment.Size = new System.Drawing.Size(400, 368);
            this.dgvPayment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voucher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(354, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(170, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(267, 48);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "C";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guest money";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "5%=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTax.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(102, 85);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(254, 35);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "B";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Guest information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Point";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPoint.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Black;
            this.lblPoint.Location = new System.Drawing.Point(147, 62);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(21, 19);
            this.lblPoint.TabIndex = 23;
            this.lblPoint.Text = "D";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBCheckGuest
            // 
            this.pBCheckGuest.Location = new System.Drawing.Point(363, 5);
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
            this.btnYes.Location = new System.Drawing.Point(393, 3);
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
            this.btnPayReceipt.Location = new System.Drawing.Point(8, 169);
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
            this.btnVoucherConfirm.Location = new System.Drawing.Point(318, 22);
            this.btnVoucherConfirm.Name = "btnVoucherConfirm";
            this.btnVoucherConfirm.Size = new System.Drawing.Size(33, 33);
            this.btnVoucherConfirm.TabIndex = 13;
            this.btnVoucherConfirm.UseVisualStyleBackColor = true;
            this.btnVoucherConfirm.Click += new System.EventHandler(this.btnVoucherConfirm_Click);
            // 
            // pBGuestMoney
            // 
            this.pBGuestMoney.Location = new System.Drawing.Point(289, 19);
            this.pBGuestMoney.Name = "pBGuestMoney";
            this.pBGuestMoney.Size = new System.Drawing.Size(32, 32);
            this.pBGuestMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGuestMoney.TabIndex = 12;
            this.pBGuestMoney.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_Remake.Properties.Resources.Tax_48;
            this.pictureBox2.Location = new System.Drawing.Point(7, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pBVoucher
            // 
            this.pBVoucher.Location = new System.Drawing.Point(93, 27);
            this.pBVoucher.Name = "pBVoucher";
            this.pBVoucher.Size = new System.Drawing.Size(24, 24);
            this.pBVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVoucher.TabIndex = 6;
            this.pBVoucher.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(36, 94);
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
            this.cbUsePoint.Location = new System.Drawing.Point(8, 94);
            this.cbUsePoint.Name = "cbUsePoint";
            this.cbUsePoint.Size = new System.Drawing.Size(24, 24);
            this.cbUsePoint.TabIndex = 26;
            this.cbUsePoint.CheckedChanged += new System.EventHandler(this.cbUsePoint_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Guest name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameGuest
            // 
            this.lblNameGuest.AutoSize = true;
            this.lblNameGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblNameGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameGuest.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGuest.ForeColor = System.Drawing.Color.Black;
            this.lblNameGuest.Location = new System.Drawing.Point(149, 36);
            this.lblNameGuest.Name = "lblNameGuest";
            this.lblNameGuest.Size = new System.Drawing.Size(19, 19);
            this.lblNameGuest.TabIndex = 28;
            this.lblNameGuest.Text = "C";
            this.lblNameGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.txtGuestMoney);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pBGuestMoney);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPayReceipt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(400, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 223);
            this.panel2.TabIndex = 29;
            // 
            // txtGuestMoney
            // 
            this.txtGuestMoney.AutoRoundedCorners = true;
            this.txtGuestMoney.BorderRadius = 9;
            this.txtGuestMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestMoney.DefaultText = "";
            this.txtGuestMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuestMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuestMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuestMoney.ForeColor = System.Drawing.Color.Black;
            this.txtGuestMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestMoney.Location = new System.Drawing.Point(6, 26);
            this.txtGuestMoney.Name = "txtGuestMoney";
            this.txtGuestMoney.PasswordChar = '\0';
            this.txtGuestMoney.PlaceholderText = "";
            this.txtGuestMoney.SelectedText = "";
            this.txtGuestMoney.Size = new System.Drawing.Size(277, 21);
            this.txtGuestMoney.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtVoucher);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTax);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pBVoucher);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnVoucherConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 268);
            this.panel3.TabIndex = 6;
            // 
            // txtVoucher
            // 
            this.txtVoucher.AutoRoundedCorners = true;
            this.txtVoucher.BorderRadius = 9;
            this.txtVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoucher.DefaultText = "";
            this.txtVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVoucher.ForeColor = System.Drawing.Color.Black;
            this.txtVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVoucher.Location = new System.Drawing.Point(123, 30);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.PasswordChar = '\0';
            this.txtVoucher.PlaceholderText = "";
            this.txtVoucher.SelectedText = "";
            this.txtVoucher.Size = new System.Drawing.Size(189, 21);
            this.txtVoucher.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.txtGuestPhone);
            this.panel4.Controls.Add(this.btnYes);
            this.panel4.Controls.Add(this.lblNameGuest);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pBCheckGuest);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbUsePoint);
            this.panel4.Controls.Add(this.lblPoint);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(3, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 120);
            this.panel4.TabIndex = 15;
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.AutoRoundedCorners = true;
            this.txtGuestPhone.BorderRadius = 9;
            this.txtGuestPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestPhone.DefaultText = "";
            this.txtGuestPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuestPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuestPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuestPhone.ForeColor = System.Drawing.Color.Black;
            this.txtGuestPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestPhone.Location = new System.Drawing.Point(168, 8);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.PasswordChar = '\0';
            this.txtGuestPhone.PlaceholderText = "";
            this.txtGuestPhone.SelectedText = "";
            this.txtGuestPhone.Size = new System.Drawing.Size(189, 21);
            this.txtGuestPhone.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::PBL3_Remake.Properties.Resources.Panel;
            this.pictureBox3.Location = new System.Drawing.Point(400, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(440, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // frmPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 526);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBVoucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pBGuestMoney;
        private System.Windows.Forms.Button btnVoucherConfirm;
        private System.Windows.Forms.Button btnPayReceipt;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pBCheckGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbUsePoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNameGuest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestMoney;
        private Guna.UI2.WinForms.Guna2TextBox txtVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestPhone;
    }
}