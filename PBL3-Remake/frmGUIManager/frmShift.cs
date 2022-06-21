using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.frmGUIManager
{
    public partial class frmShift : Form
    {
        Dictionary<CaLam, bool> listCaLam;
        List<int> ListIDCalam = new List<int>();
        int ID_NhanVien;
        public frmShift(int ID_NhanVien)
        {
            InitializeComponent();
            this.listCaLam = CaLamBLL.Instance.GetAllCaLamByID_NhanVien(ID_NhanVien);
            this.ID_NhanVien = ID_NhanVien;
        }
        private void DelIDCalam(int IDCalam)
        {
            ListIDCalam.Remove(IDCalam);
        }
        private void AddIDCalam(int IDCalam)
        {
            ListIDCalam.Add(IDCalam);
        }
        private void frmShift_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<CaLam, bool> i in listCaLam)
            {
                frmGUIUserControl.CheckBoxUC uc = new frmGUIUserControl.CheckBoxUC(i);
                uc.Add = new frmGUIUserControl.CheckBoxUC.AddDelegate(AddIDCalam);
                uc.Remove = new frmGUIUserControl.CheckBoxUC.RemoveDelegate(DelIDCalam);
                pnCaLam.Controls.Add(uc);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ListIDCalam.Count > 0)
            {
                //CaLamBLL.Instance.SetCaLamForNhanVien(ID_NhanVien, ListIDCalam);
                this.Close();
            }
            else
            {
                NoticeBox box = new NoticeBox("please select at least one shift!!");
                box.ShowDialog();
            }
        }
    }
}
