using DTO;
using System;
using System.Windows.Forms;

namespace PBL3_Remake.frmGUISeller
{
    public partial class frmCollaborTable : Form
    {
        public int IDCollabTable { get; set; }
        public Ban ban { get; set; }
        public frmCollaborTable(Ban tb)
        {
            InitializeComponent();
            if(tb.TinhTrangBan != 0)
                cboBan.Items.AddRange(BLL.BLLNVNH.Instance.GetMainBanByTinhTrangBanVaTang(-1,tb.Tang).ToArray());
            else
            {
                cboBan.Items.AddRange(BLL.BLLNVNH.Instance.GetMainBanByTinhTrangBanVaTang(0, tb.Tang).ToArray());
            }
            ban = tb;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cboBan.SelectedIndex != -1) 
                BLL.BLLNVNH.Instance.SetCollabTable(ban, ((Ban)cboBan.SelectedItem).ID_Ban);
            this.Close();
        }
    }
}
