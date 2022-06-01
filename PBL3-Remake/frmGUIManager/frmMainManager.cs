using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.frmGUIUserControl;
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
            SetupUC(OverViewUC.Instance);
            SetupUC(EmployeesUC.Instance);
            SetupUC(HelpUC.Instance);
            SetupUC(StatisticUC.Instance);
            SetupUC(WareHouseUC.Instance);
            SetupUC(ManagerFoodUC.Instance);
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            OverViewUC.Instance.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            EmployeesUC.Instance.BringToFront();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            WareHouseUC.Instance.BringToFront();
        }

        private void btnStatictis_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            StatisticUC.Instance.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            HelpUC.Instance.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ManagerFoodUC.Instance.BringToFront();
        }
    }
}
