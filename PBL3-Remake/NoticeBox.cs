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
        }

        private void NoticeBox_Load(object sender, System.EventArgs e)
        {
            lblMessage.Text = Notice;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
