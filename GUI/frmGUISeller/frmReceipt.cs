using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmReceipt : Form
    {
        int ID_Table, ID_Invoice;
        public frmReceipt(int ID_Table, int ID_Invoice)
        {
            InitializeComponent();
            this.ID_Table = ID_Table;
            this.ID_Invoice = ID_Invoice;
        }

        private void frmRecept_Load(object sender, EventArgs e)
        {
            DataSet ds = BLL.ExtensionBLL.Instance.ToDataSet(BLL.HoaDonBLL.Instance.SetDataSetForReceipt(ID_Table, ID_Invoice));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Receipt.PrintReceipt.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }


    }
}
