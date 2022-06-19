using DTO;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class DetailTable : Form
    {
        public int ID_Table_view { get; set; }
        public DetailTable(int ID_Table_view)
        {
            this.ID_Table_view = ID_Table_view;
            InitializeComponent();
            GUI();
        }

        private void GUI()
        {
            int sum = 0;
            dgvTable_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable_view.DataSource = BLL.BLLNVNH.Instance.GetAllDish_viewByIDDetailTable(ID_Table_view);
            foreach (MonAn_View i in BLL.BLLNVNH.Instance.GetAllDish_viewByIDDetailTable(ID_Table_view))
            {
                sum += i.ThanhTien;
            }
            lblNumberOfDishes.Text = BLL.BLLNVNH.Instance.GetAllDish_viewByIDDetailTable(ID_Table_view).Count.ToString();
            lblTotal.Text = sum.ToString();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
