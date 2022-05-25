using BLL;
using System;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmStatusDish : Form
    {
        public int ID { get; set; }
        public frmStatusDish(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void frmStatusDish_Load(object sender, System.EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            Console.WriteLine("ID " + ID + " " + BLLNVNH.Instance.GetDetailTableByID(ID).MonAn);
            lblNameDish.Text = BLLNVNH.Instance.GetDetailTableByID(ID).MonAn + " amount" + BLLNVNH.Instance.GetDetailTableByID(ID).SoLuong;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, System.EventArgs e)
        {
            BLLNVNH.Instance.ChangeStatusDishByID(ID);
        }
    }
}
