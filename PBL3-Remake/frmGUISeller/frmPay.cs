using BLL;
using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmPay : Form
    {
        List<MonAn_View> listMonAnViewDaDat;
        public delegate void Mydel();
        public Mydel d;
        public int IDTable { get; set; }
        public frmPay(int idban)
        {
            IDTable = idban;
            InitializeComponent();
            SetCollabTableTextBox();
        }
        List<string> Voucher = new List<string>();
        private void AddVoucher()
        {
            Voucher.Add("Voucher123");
            Voucher.Add("KM50%");
            Voucher.Add("KM20%");
            Voucher.Add("Giam50k");
        }
        private void frmPay_Load(object sender, EventArgs e)
        {
            listMonAnViewDaDat = MonAnBLL.Instance.GetListMonAnByIDBan(IDTable);
            dgvPayment.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
            AddVoucher();
            AutoCompleteStringCollection autoVoucher = new AutoCompleteStringCollection();
            txtVoucher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVoucher.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string i in Voucher)
            {
                autoVoucher.Add(i);
            }
            txtVoucher.AutoCompleteCustomSource = autoVoucher;
            lblTotal.Text = (sum + tax).ToString();
        }
        private void LoadDataGridView(List<MonAn_View> lt)
        {
            if (lt != null)
            {
                dgvPayment.Columns[0].Visible = false;
                dgvPayment.Columns[1].HeaderText = "Name dish";
                dgvPayment.Columns[2].HeaderText = "Number";
                dgvPayment.Columns[3].HeaderText = "Total";
                dgvPayment.DataSource = lt;
                Load_Total();
            }
        }
        int guestmoney;
        int sum = 0;
        int tax;
        string txtcollab = "";
        string txtMain = "";
        private void Load_Total()
        {

            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                sum += Convert.ToInt32(row.Cells[3].Value.ToString());
            }
            lblBill.Text = sum.ToString();
            if (txtGuestMoney.Text.Length > 0)
            {
                guestmoney = Convert.ToInt32(txtGuestMoney.ToString());
            }
            tax = sum / 100 * 5;
            lblTax.Text = tax.ToString();
        }

        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            if (txtVoucher.Text == "Voucher123" || txtVoucher.Text == "km123" || txtVoucher.Text == "QLNH111")
            {
                pBVoucher.Image = PBL3_Remake.Properties.Resources.checkedGreen;
            }
            else pBVoucher.Image = PBL3_Remake.Properties.Resources.uncheckedRed;
        }

        private void txtGuestMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtGuestMoney.Text.Length != 0)
                guestmoney = Convert.ToInt32(txtGuestMoney.Text);
            if (guestmoney > (sum + tax))
            {
                pBGuestMoney.Image = PBL3_Remake.Properties.Resources.checkedGreen;
            }
            else pBGuestMoney.Image = PBL3_Remake.Properties.Resources.uncheckedRed;
        }

        private void btnVoucherConfirm_Click(object sender, EventArgs e)
        {
            sum -= 50000;
            lblTotal.Text = (sum + tax).ToString();
            txtVoucher.Text = "";
            pBVoucher.Image = null;
        }

        private void btnPayReceipt_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void SetCollabTableTextBox()
        {
            txtAllCollabTable.Enabled = false;
            Ban bn = BLLNVNH.Instance.GetBanByID_Ban(IDTable);
            txtcollab = BLLNVNH.Instance.GetAllCollabTable(bn, bn.TinhTrangBan, txtcollab);
            txtMain = BLLNVNH.Instance.GetAllMainTable(bn, txtMain);
            txtAllCollabTable.Text = txtMain + " " + txtcollab;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            d();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportPDF_Click(object sender, EventArgs e)
        {
            NoticeBox frmnotice = new NoticeBox("");
            string mess = "";
            if (dgvPayment.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvPayment.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvPayment.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvPayment.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            mess = "Export successfully!!!";
                            frmnotice = new NoticeBox(mess);
                            frmnotice.Show();
                        }
                        catch (Exception ex)
                        {
                            mess = "Error:" + ex.Message;
                            frmnotice = new NoticeBox(mess);
                            frmnotice.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }
    }
}
