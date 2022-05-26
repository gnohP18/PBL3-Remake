using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class frmMainManager : Form
    {
        public frmMainManager()
        {
            InitializeComponent();
        }

        void SetupUC(UserControl uc)
        {
            pnUC.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            //highlight button
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            //btn.RightToLeft = RightToLeft.Yes;
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {
                //btn.RightToLeft = RightToLeft.No;
                CurrentButton.BackColor = Color.FromArgb(17, 21, 37);
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;
        }
        private void frmMainManager_Load(object sender, EventArgs e)
        {
            SetupUC(backupUC);
            SetupUC(employeesUC);
            SetupUC(statisticUC);
            SetupUC(wareHouseUC);
            SetupUC(managerFoodUC);
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            //overviewUC.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            employeesUC.BringToFront();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            wareHouseUC.BringToFront();
        }

        private void btnStatictis_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            statisticUC.BringToFront();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            managerFoodUC.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            //helpUC.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
