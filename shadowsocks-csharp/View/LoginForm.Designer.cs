namespace Shadowsocks.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgetPassWord = new System.Windows.Forms.Label();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtPassWord = new Shadowsocks.View.TextBoxEx(this.components);
            this.txtAccount = new Shadowsocks.View.TextBoxEx(this.components);
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(555, 299);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(194, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblForgetPassWord
            // 
            this.lblForgetPassWord.AutoSize = true;
            this.lblForgetPassWord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblForgetPassWord.Location = new System.Drawing.Point(688, 266);
            this.lblForgetPassWord.Name = "lblForgetPassWord";
            this.lblForgetPassWord.Size = new System.Drawing.Size(65, 12);
            this.lblForgetPassWord.TabIndex = 1;
            this.lblForgetPassWord.Text = "忘记密码？";
            this.lblForgetPassWord.MouseEnter += new System.EventHandler(this.lblForgetPassWord_MouseEnter);
            this.lblForgetPassWord.MouseLeave += new System.EventHandler(this.lblForgetPassWord_MouseLeave);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(555, 263);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(60, 16);
            this.chkRemember.TabIndex = 5;
            this.chkRemember.Text = "记住我";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "还没账户？";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRegister.Location = new System.Drawing.Point(614, 352);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(53, 12);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "立即注册";
            this.lblRegister.MouseEnter += new System.EventHandler(this.lblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            // 
            // txtPassWord
            // 
            this.txtPassWord.EmptyTextTip = "请输入密码";
            this.txtPassWord.Location = new System.Drawing.Point(555, 198);
            this.txtPassWord.Multiline = true;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(194, 32);
            this.txtPassWord.TabIndex = 4;
            // 
            // txtAccount
            // 
            this.txtAccount.EmptyTextTip = "请输入账户或者电话号码";
            this.txtAccount.Location = new System.Drawing.Point(555, 128);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(194, 32);
            this.txtAccount.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblForgetPassWord);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgetPassWord;
        private TextBoxEx txtAccount;
        private TextBoxEx txtPassWord;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegister;
    }
}