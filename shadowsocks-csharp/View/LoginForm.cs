using Newtonsoft.Json;
using Shadowsocks.Proxy;
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
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Dictionary<string, string> dictResult = new Dictionary<string, string>();
            dict.Add("account", txtAccount.Text);
            dict.Add("password", txtPassWord.Text);
            string resultStr=HttpHelper.Post("http://localhost:8000/accounts/sockLogin/", dict);
            dictResult=JsonConvert.DeserializeObject<Dictionary<string,string>>(resultStr);
            if (dictResult["resultCode"] != "0")
            {
                MessageBox.Show(dictResult["msg"]);
                //this.DialogResult = DialogResult.No;
                return;
                //this.Close();
            }
            else {
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
        }
    }
}
