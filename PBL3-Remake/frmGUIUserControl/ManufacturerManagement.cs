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
namespace GUI.frmGUIUserControl
{
    public partial class ManufacturerManagement : Form
    {
        public ManufacturerManagement()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {   
            dgvNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetAllNhaCungCap();
        }
        private void btnAddNewManufacturer_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.AddNewManufacturer frm = new AddNewManufacturer();
            frm.Show();
        }

        private void btnDetailManufacturer_Click(object sender, EventArgs e)
        {   if(dgvNhaCungCap.SelectedRows.Count == 1)
            {
                int IDNCC = Convert.ToInt32(dgvNhaCungCap.SelectedRows[0].Cells["ID_NhaCungCap"].Value.ToString());
                frmGUIUserControl.DetailManufacturer frm = new DetailManufacturer(IDNCC);
                frm.Show();
            }
        else
            {
                NoticeBox box = new NoticeBox("Please choose one manufacturer to view details");
                box.Show();
            }    
            
        }


    }
}
