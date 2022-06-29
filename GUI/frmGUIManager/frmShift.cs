using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.frmGUIUCForManager;
using Entity;
namespace GUI.frmGUIManager
{
    public partial class frmShift : Form
    {
        public frmShift(int ID_NhanVien)
        {
            InitializeComponent();
            this.listCaLam = CaLamBLL.Instance.GetAllCaLamByID_NhanVien(ID_NhanVien);
            this.ID_NhanVien = ID_NhanVien;
        }
        #region Local Variable
        Dictionary<CaLam, bool> listCaLam;
        List<int> ListIDCalam = new List<int>();
        int ID_NhanVien;

        #endregion
        #region Function
        private void DelIDCalam(int IDCalam)
        {
            ListIDCalam.Remove(IDCalam);
        }
        private void AddIDCalam(int IDCalam)
        {
            ListIDCalam.Add(IDCalam);
        }
        #endregion
        #region Event FORM
        private void frmShift_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<CaLam, bool> i in listCaLam)
            {
                if(i.Value == true)
                    ListIDCalam.Add(i.Key.ID_CaLam);
                CheckBoxUC uc = new CheckBoxUC(i);
                uc.Add = new CheckBoxUC.AddDelegate(AddIDCalam);
                uc.Remove = new CheckBoxUC.RemoveDelegate(DelIDCalam);
                pnCaLam.Controls.Add(uc);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ListIDCalam.Count > 0)
            {
                CaLamBLL.Instance.SetCaLamForNhanVien(ID_NhanVien, ListIDCalam);
                this.Close();
            }
            else
            {
                NoticeBox box = new NoticeBox("please select at least one shift!!");
                box.ShowDialog();
            }
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
