using System.Drawing;
using System.Windows.Forms;

namespace PBL3_Remake.GUI.frmGUIUserControl
{
    public partial class EmployeesUC : UserControl
    {
        public EmployeesUC()
        {
            InitializeComponent();
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

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SetUIForButton(sender);
        }
    }
}
