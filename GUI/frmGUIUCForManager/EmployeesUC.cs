using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.frmGUIManager;
namespace GUI.frmGUIUCForManager
{
    public partial class EmployeesUC : UserControl
    {
        #region Instance
        private static EmployeesUC _Instance;
        public static EmployeesUC Instance
        {
            get { if (_Instance == null) _Instance = new EmployeesUC(); return _Instance; }
        }
        public EmployeesUC()
        {
            InitializeComponent();
        }
        #endregion
        #region Local Variable
        private Button CurrentButton;
        #endregion
        #region Function 
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
        private void LoadDataGridView()
        {
            dgvManageEmployee.DataSource = BLL.NhanVienBLL.Instance.GetAllEmployee_view();
            dgvManageEmployee.Columns[1].Width = 150;
        }
        #endregion
        #region Event UC
        private void EmployeesUC_Load(object sender, System.EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnDeleteEmployee_Click(object sender, System.EventArgs e)
        {
            SetUIForButton(sender);
            int index = dgvManageEmployee.CurrentCell.RowIndex;
            int ID_User = Convert.ToInt32(dgvManageEmployee.Rows[index].Cells[0].Value.ToString());
            NoticeBox frm = new NoticeBox("You have deleted User " + ID_User);
            frm.Show();
            BLL.NhanVienBLL.Instance.DeleteEmployee(ID_User);
            LoadDataGridView();
        }

        private void btnAddEmployee_Click_1(object sender, System.EventArgs e)
        {
            SetUIForButton(sender);
            DetailEmployee frm = new DetailEmployee(-1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.d = new DetailEmployee.Mydel(LoadDataGridView);
            frm.Show();
        }

        private void btnTimeSheetEmployee_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            int index = dgvManageEmployee.CurrentCell.RowIndex;
            int ID_User = Convert.ToInt32(dgvManageEmployee.Rows[index].Cells[0].Value.ToString());
            User _User = BLL.NhanVienBLL.Instance.GetNhanVienByID(ID_User);
            if (_User.ID_ChucVu != 1 || _User.ID_ChucVu != 2)
            {
                EmployeeTimeSheet frm = new EmployeeTimeSheet(ID_User);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            else
            {
                if (_User.ID_ChucVu == 1)
                {
                    NoticeBox box = new NoticeBox("This is Admin-Can't have TimeSheet");
                    box.Show();
                }
                else if (_User.ID_ChucVu == 2)
                {
                    NoticeBox box = new NoticeBox("This is Manager-Can't have TimeSheet");
                    box.Show();
                }
            }
        }
        private void btnSalaryManage_Click(object sender, EventArgs e)
        {
            this.Controls.Add(SalaryManageUC.Instance);
            SalaryManageUC.Instance.Dock = DockStyle.Fill;
            SalaryManageUC.Instance.BringToFront();
            SetUIForButton(sender);
        }

        private void dgvManageEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvManageEmployee.CurrentCell.RowIndex;
            int ID_User = Convert.ToInt32(dgvManageEmployee.Rows[index].Cells[0].Value.ToString());
            DetailEmployee frm = new DetailEmployee(ID_User);
            frm.d = new DetailEmployee.Mydel(LoadDataGridView);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void pBDGV_Click(object sender, EventArgs e)
        {
            dgvManageEmployee.BringToFront();
        }
        #endregion

    }
}
