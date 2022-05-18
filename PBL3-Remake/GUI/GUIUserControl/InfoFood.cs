using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Remake.GUI.frmGUIUserControl
{
    public partial class InfoFood : Form
    {
        public InfoFood()
        {
            InitializeComponent();
        }
        void GUI()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            dgvInforInputFood.Columns.Add("STT", "STT");
            dgvInforInputFood.Columns.Add("MaNguyenLieu", "Mã Nguyên Liệu");
            dgvInforInputFood.Columns.Add("MaNhaCungCap", "Mã nhà cung cấp");
            dgvInforInputFood.Columns.Add("NgayNhap", "Ngày nhập");
            dgvInforInputFood.Columns.Add("DinhLuong", "Định lượng");
            dgvInforInputFood.Rows.Add("1", "101", "NCC102", "20/4/2022", "9kg");
            dgvInforInputFood.Rows.Add("2", "101", "NCC103", "20/4/2022", "7kg");
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            //Highlighjt button
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {

                CurrentButton.BackColor = Color.FromArgb(17, 21, 37);
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            txtFoodID.Enabled = true;
            txtFoodName.Enabled = true;
            txtCurrentQuantity.Enabled = true;
            txtInputDay.Enabled = true;
            txtTenNhaCungCap.Enabled = true;
            txtMaNhaCungCap.Enabled = true;
        }
    }
}
