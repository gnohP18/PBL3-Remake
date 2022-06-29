using System;
using System.Windows.Forms;

namespace GUI.frmGUIUCForManager
{
    public partial class MainMenuUC : UserControl
    {
        private static MainMenuUC _Instance;
        public static MainMenuUC Instance
        {
            get { if (_Instance == null) _Instance = new MainMenuUC(); return _Instance; }
        }
        public MainMenuUC()
        {
            InitializeComponent();
            timer_pick.Start();
        }
        #region Function
        #endregion
        #region Event UC
        private void timer_pick_Tick(object sender, System.EventArgs e)
        {
            lblRealTime.Text = DateTime.Now.ToLongTimeString();
        }


        private void linkFb1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tk.sin.33");
        }
        #endregion

        private void linkFb2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100010835591776");
        }

        private void linkFb3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nxhung02");
        }
    }
}
