using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace NasimImageEditor.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblAppVersion.Text = $@"V-{Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void pbCompanyLogo_Click(object sender, EventArgs e)
        {
            try
            {
                using var pr = Process.Start(@"http://ahmadrezadev.ir/donate");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(this,
                    "خطایی به هنگام اجرای دستور رخ داده است، لطفا دوباره امتحان کنید.",
                    "خطایی رخ داده است!");
            }
        }
    }
}