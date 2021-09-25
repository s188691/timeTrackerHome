
namespace timeTrackerHome
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
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.logoRegister = new System.Windows.Forms.PictureBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.emailTextBoxLogin = new System.Windows.Forms.TextBox();
            this.passwordTextBoxLogin = new System.Windows.Forms.TextBox();
            this.loginAccountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(291, 290);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(73, 15);
            this.linkLabelGithub.TabIndex = 7;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub repo";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // logoRegister
            // 
            this.logoRegister.Location = new System.Drawing.Point(97, 28);
            this.logoRegister.Name = "logoRegister";
            this.logoRegister.Size = new System.Drawing.Size(182, 87);
            this.logoRegister.TabIndex = 6;
            this.logoRegister.TabStop = false;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Location = new System.Drawing.Point(215, 290);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(51, 15);
            this.linkLabelSignUp.TabIndex = 8;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Sign Up";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // emailTextBoxLogin
            // 
            this.emailTextBoxLogin.Location = new System.Drawing.Point(97, 165);
            this.emailTextBoxLogin.Name = "emailTextBoxLogin";
            this.emailTextBoxLogin.Size = new System.Drawing.Size(182, 20);
            this.emailTextBoxLogin.TabIndex = 9;
            // 
            // passwordTextBoxLogin
            // 
            this.passwordTextBoxLogin.Location = new System.Drawing.Point(97, 191);
            this.passwordTextBoxLogin.Name = "passwordTextBoxLogin";
            this.passwordTextBoxLogin.Size = new System.Drawing.Size(182, 20);
            this.passwordTextBoxLogin.TabIndex = 10;
            // 
            // loginAccountBtn
            // 
            this.loginAccountBtn.Location = new System.Drawing.Point(129, 230);
            this.loginAccountBtn.Name = "loginAccountBtn";
            this.loginAccountBtn.Size = new System.Drawing.Size(112, 23);
            this.loginAccountBtn.TabIndex = 11;
            this.loginAccountBtn.Text = "button1";
            this.loginAccountBtn.UseVisualStyleBackColor = true;
            this.loginAccountBtn.Click += new System.EventHandler(this.loginAccountBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 314);
            this.Controls.Add(this.loginAccountBtn);
            this.Controls.Add(this.passwordTextBoxLogin);
            this.Controls.Add(this.emailTextBoxLogin);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.logoRegister);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.PictureBox logoRegister;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.TextBox emailTextBoxLogin;
        private System.Windows.Forms.TextBox passwordTextBoxLogin;
        private System.Windows.Forms.Button loginAccountBtn;
    }
}