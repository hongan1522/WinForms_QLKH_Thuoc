using FormQLKH;
using System.Windows.Forms;
namespace WinFormsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            UC_Login uC_Login1 = new UC_Login();
            uC_Login1.SuccessEvent += uC_Login1_SuccessEvent;
        }

        private void uC_Login1_SuccessEvent(object sender, EventArgs e)
        {
            Close();
            Frm_QuanLy frmQL = new Frm_QuanLy();
            frmQL.Show();
        }
    }
}