
namespace timeTrackerHome
{
    partial class RegisterForm
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
            this.emailTextBoxRegister = new System.Windows.Forms.TextBox();
            this.passwordTextBoxRegister = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.logoRegister = new System.Windows.Forms.PictureBox();
            this.linkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBoxRegister
            // 
            this.emailTextBoxRegister.Location = new System.Drawing.Point(91, 147);
            this.emailTextBoxRegister.Name = "emailTextBoxRegister";
            this.emailTextBoxRegister.Size = new System.Drawing.Size(182, 20);
            this.emailTextBoxRegister.TabIndex = 0;
            // 
            // passwordTextBoxRegister
            // 
            this.passwordTextBoxRegister.Location = new System.Drawing.Point(91, 184);
            this.passwordTextBoxRegister.Name = "passwordTextBoxRegister";
            this.passwordTextBoxRegister.Size = new System.Drawing.Size(182, 20);
            this.passwordTextBoxRegister.TabIndex = 1;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(119, 223);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(124, 34);
            this.createAccountBtn.TabIndex = 2;
            this.createAccountBtn.Text = "button1";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoRegister
            // 
            this.logoRegister.Location = new System.Drawing.Point(91, 26);
            this.logoRegister.Name = "logoRegister";
            this.logoRegister.Size = new System.Drawing.Size(182, 87);
            this.logoRegister.TabIndex = 3;
            this.logoRegister.TabStop = false;
            // 
            // linkLabelSignIn
            // 
            this.linkLabelSignIn.AutoSize = true;
            this.linkLabelSignIn.Location = new System.Drawing.Point(209, 281);
            this.linkLabelSignIn.Name = "linkLabelSignIn";
            this.linkLabelSignIn.Size = new System.Drawing.Size(45, 15);
            this.linkLabelSignIn.TabIndex = 4;
            this.linkLabelSignIn.TabStop = true;
            this.linkLabelSignIn.Text = "Sign In";
            this.linkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignIn_LinkClicked);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(296, 281);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(73, 15);
            this.linkLabelGithub.TabIndex = 5;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub repo";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 305);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.linkLabelSignIn);
            this.Controls.Add(this.logoRegister);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.passwordTextBoxRegister);
            this.Controls.Add(this.emailTextBoxRegister);
            this.Name = "RegisterForm";
            this.Text = "TTH - Register";
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBoxRegister;
        private System.Windows.Forms.TextBox passwordTextBoxRegister;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.PictureBox logoRegister;
        private System.Windows.Forms.LinkLabel linkLabelSignIn;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
    }
}

