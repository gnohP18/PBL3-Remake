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
namespace GUI.frmGUIUserControl
{
    public partial class AddNewMaterial : Form
    {
        public AddNewMaterial()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cbbKindOfMaterial.Items.AddRange(BLLQLNH.Instance.GetAllLoaiNguyenLieu().ToArray());
            cbbKindOfMaterial.DisplayMember = "TenLoaiNguyenLieu";
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
