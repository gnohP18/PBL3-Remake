using System;
using System.Windows.Forms;

namespace PBL3_Remake.frmGUISeller
{
    public partial class frmCollaborTable : Form
    {
        public int IDCollabTable { get; set; }
        public frmCollaborTable()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            IDCollabTable = Convert.ToInt32(txtIDCollabTable.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
