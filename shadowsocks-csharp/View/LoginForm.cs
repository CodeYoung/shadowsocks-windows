using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblForgetPassWord_MouseEnter(object sender, EventArgs e)
        {
            lblForgetPassWord.ForeColor = Color.ForestGreen;
            this.Cursor = Cursors.Hand;
        }

        private void lblForgetPassWord_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPassWord.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
