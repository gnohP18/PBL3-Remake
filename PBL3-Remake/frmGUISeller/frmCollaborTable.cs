using Entity;
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
            ban = tb;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            BLL.BLLNVNH.Instance.SetCollabTable(ban, IDCollabTable);
            this.Close();
        }
    }
}
