using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI.frmGUIManager
{
    public partial class ManufacturerManagement : Form
    {
        public ManufacturerManagement()
        {
            InitializeComponent();
            dgvNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetAllNhaCungCap();
            dgvNhaCungCap.Columns["ChiTietNhaCungCaps"].Visible = false;
            dgvNhaCungCap.Columns["Khoes"].Visible = false;
            LoadDgv();
        }
        void LoadDgv()
        {   
            dgvNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetAllNhaCungCap();
        }
        private void btnAddNewManufacturer_Click(object sender, EventArgs e)
        {
            frmGUIManager.AddNewManufacturer frm = new AddNewManufacturer();
            frm.Show();
        }

        private void btnDetailManufacturer_Click(object sender, EventArgs e)
        {   if(dgvNhaCungCap.SelectedRows.Count == 1)
            {
                int IDNCC = Convert.ToInt32(dgvNhaCungCap.SelectedRows[0].Cells["ID_NhaCungCap"].Value.ToString());
                frmGUIManager.DetailManufacturer frm = new DetailManufacturer(IDNCC);
                frm.d = new DetailManufacturer.MyDel(LoadDgv);
                frm.Show();
            }
        else
            {
                NoticeBox box = new NoticeBox("Please choose one manufacturer to view details");
                box.Show();
            }    
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
