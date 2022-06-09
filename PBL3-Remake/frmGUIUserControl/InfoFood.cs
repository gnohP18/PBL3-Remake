using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class InfoFood : Form
    {
        public int IDNL { get; set; }
        public InfoFood(int ID)
        {
            IDNL = ID;
            InitializeComponent();
            GUI();
        }
        void GUI()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            txtFoodID.Text = Convert.ToString(IDNL);
            dgvInforInputFood.ReadOnly = true;
            dgvInforInputFood.DataSource = NhaCungCapBLL.Instance.GetTT(IDNL);
        }

        public void GetDataToDGV(int id)
        {

        }
        private Button CurrentButton;

        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            //Highlight button
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {

                CurrentButton.BackColor = Color.FromArgb(17, 21, 37);
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            txtFoodID.Enabled = true;
            txtFoodName.Enabled = true;
            txtCurrentQuantity.Enabled = true;
            txtInputDay.Enabled = true;
            txtTenNhaCungCap.Enabled = true;
            txtMaNhaCungCap.Enabled = true;
        }

        private void InfoFood_Load(object sender, EventArgs e)
        {

        }
    }
}
