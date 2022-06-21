using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI.frmGUIUserControl
{
    public partial class CheckBoxUC : UserControl
    {
        KeyValuePair<User, bool> user;
        KeyValuePair<CaLam, bool> calam;
        public delegate void AddDelegate(int ID);
        public delegate void RemoveDelegate(int ID);
        public AddDelegate Add;
        public RemoveDelegate Remove;
        bool isDiemDanh;
        public CheckBoxUC(KeyValuePair<User,bool> user)
        {
            InitializeComponent();
            this.user = user;
            GUIforDiemDanh();
            isDiemDanh = true;
        }
        public CheckBoxUC(KeyValuePair<CaLam, bool> calam)
        {
            InitializeComponent();
            this.calam = calam;
            GUIforCalam();
            isDiemDanh = false;
        }

        private void GUIforCalam()
        {
            lbMess1.Text =CaLamBLL.Instance.GetStringCaLamTheoSangChieuByIDCalam(calam.Key.ID_CaLam,true);
            lbMess2.Text =CaLamBLL.Instance.GetStringCaLamTheoSangChieuByIDCalam(calam.Key.ID_CaLam, false);
            if(calam.Value == false)
            {
                picCheck.Visible = false;
            }
            else
            {
                picUnchecked.Visible = false;
            }
        }

        private void GUIforDiemDanh()
        {
            lbMess1.Text = user.Key.TenUser;
            lbMess2.Text = "CMND : " + user.Key.CMND_CCCD;
            if(user.Value == false)
            {
                picCheck.Visible = false;
            }
            else
            {
                picUnchecked.Visible = false;
            }
        }

        private void picCheck_Click(object sender, EventArgs e)
        {
            if(isDiemDanh == true)
            {
                if(picCheck.Visible == false)
                {
                    picCheck.Visible = true;
                    picUnchecked.Visible = false;
                    Add(user.Key.ID_User);
                }
            }
            if(isDiemDanh == false)
            {
                if (picCheck.Visible == false)
                {
                    picCheck.Visible = true;
                    picUnchecked.Visible = false;
                    Add(calam.Key.ID_CaLam);
                }
                else
                {
                    picCheck.Visible = false;
                    picUnchecked.Visible = true;
                    Remove(calam.Key.ID_CaLam);
                }
            }

        }
    }
}
