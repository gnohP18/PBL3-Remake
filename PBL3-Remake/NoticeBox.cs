using System.Windows.Forms;

namespace GUI
{
    public partial class NoticeBox : Form
    {
        public string Notice { get; set; }
        public NoticeBox(string message)
        {
            Notice = message;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cbbTest.Items.Add("Abc");
            cbbTest.Items.Add("P");
            cbbTest.Items.Add("H");
            cbbTest.Items.Add("O");
            cbbTest.Items.Add("N");
            cbbTest.Items.Add("G");
        }

        private void NoticeBox_Load(object sender, System.EventArgs e)
        {
            lblMessage.Text = Notice;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
