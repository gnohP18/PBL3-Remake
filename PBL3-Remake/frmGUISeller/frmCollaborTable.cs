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
            IDCollabTable = Convert.ToInt32(txtIDCollabTable.Text);
            //BLL.BLLNVNH.Instance.ChangeStatusTable(ban.ID_Ban, IDCollabTable);
            //BLL.BLLNVNH.Instance.ChangeStatusTable(IDCollabTable, IDCollabTable);
            Console.WriteLine("ban " + ban.ID_Ban + " tt " + ban.TinhTrangBan);
            BLL.BLLNVNH.Instance.FindCollabTable(ban, IDCollabTable);
            foreach (Ban i in BLL.BLLNVNH.Instance.GetAllBanByTang(2))
            {
                Console.WriteLine(i.ID_Ban + " " + i.TinhTrangBan);
            }
            this.Close();
        }
    }
}
