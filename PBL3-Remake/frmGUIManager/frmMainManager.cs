using GUI.frmGUIUserControl;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI.frmGUIManager
{
    public partial class frmMainManager : Form
    {
        MainMenuUC MainMenuUC;
        OverViewUC OverViewUC;
        EmployeesUC EmployeesUC;
        HelpUC HelpUC;
        StatisticUC StatisticUC;
        WareHouseUC WareHouseUC;
        ManagerFoodUC ManagerFoodUC;
        public frmMainManager()
        {
            InitializeComponent();
            MainMenuUC = new MainMenuUC();
            OverViewUC = new OverViewUC();
            EmployeesUC = new EmployeesUC();
            HelpUC = new HelpUC();
            StatisticUC = new StatisticUC();
            WareHouseUC = new WareHouseUC();
            ManagerFoodUC = new ManagerFoodUC();
            MainMenuUC.BringToFront();
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
            SetupUC(MainMenuUC);
            SetupUC(OverViewUC);
            SetupUC(EmployeesUC);
            SetupUC(HelpUC);
            SetupUC(StatisticUC);
            SetupUC(WareHouseUC);
            SetupUC(ManagerFoodUC);
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            OverViewUC.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            EmployeesUC.BringToFront();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            WareHouseUC.BringToFront();
        }

        private void btnStatictis_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            StatisticUC.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            HelpUC.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ManagerFoodUC.BringToFront();
        }

        private void btnInforRestaurant_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            MainMenuUC.BringToFront();
        }
    }
}
