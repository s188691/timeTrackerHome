
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.emailTextBoxRegister = new System.Windows.Forms.TextBox();
            this.passwordTextBoxRegister = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.logoRegister = new System.Windows.Forms.PictureBox();
            this.linkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelLogoText = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTextBoxRegister
            // 
            this.emailTextBoxRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBoxRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBoxRegister.Location = new System.Drawing.Point(237, 107);
            this.emailTextBoxRegister.Name = "emailTextBoxRegister";
            this.emailTextBoxRegister.Size = new System.Drawing.Size(169, 20);
            this.emailTextBoxRegister.TabIndex = 0;
            // 
            // passwordTextBoxRegister
            // 
            this.passwordTextBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBoxRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBoxRegister.Location = new System.Drawing.Point(237, 139);
            this.passwordTextBoxRegister.Name = "passwordTextBoxRegister";
            this.passwordTextBoxRegister.PasswordChar = '*';
            this.passwordTextBoxRegister.Size = new System.Drawing.Size(169, 20);
            this.passwordTextBoxRegister.TabIndex = 1;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.createAccountBtn.FlatAppearance.BorderSize = 0;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(237, 181);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(169, 34);
            this.createAccountBtn.TabIndex = 2;
            this.createAccountBtn.Text = "button1";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoRegister
            // 
            this.logoRegister.Image = ((System.Drawing.Image)(resources.GetObject("logoRegister.Image")));
            this.logoRegister.Location = new System.Drawing.Point(31, 107);
            this.logoRegister.Name = "logoRegister";
            this.logoRegister.Size = new System.Drawing.Size(140, 87);
            this.logoRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoRegister.TabIndex = 3;
            this.logoRegister.TabStop = false;
            // 
            // linkLabelSignIn
            // 
            this.linkLabelSignIn.AutoSize = true;
            this.linkLabelSignIn.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabelSignIn.Location = new System.Drawing.Point(359, 283);
            this.linkLabelSignIn.Name = "linkLabelSignIn";
            this.linkLabelSignIn.Size = new System.Drawing.Size(47, 13);
            this.linkLabelSignIn.TabIndex = 4;
            this.linkLabelSignIn.TabStop = true;
            this.linkLabelSignIn.Text = "Sign In";
            this.linkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignIn_LinkClicked);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabelGithub.Location = new System.Drawing.Point(233, 283);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(75, 13);
            this.linkLabelGithub.TabIndex = 5;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub repo";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelLeft.Controls.Add(this.labelLogoText);
            this.panelLeft.Controls.Add(this.logoRegister);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(205, 305);
            this.panelLeft.TabIndex = 6;
            // 
            // labelLogoText
            // 
            this.labelLogoText.AutoSize = true;
            this.labelLogoText.BackColor = System.Drawing.Color.Transparent;
            this.labelLogoText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelLogoText.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelLogoText.Location = new System.Drawing.Point(27, 136);
            this.labelLogoText.Name = "labelLogoText";
            this.labelLogoText.Size = new System.Drawing.Size(136, 19);
            this.labelLogoText.TabIndex = 4;
            this.labelLogoText.Text = "PomodoroWellDone";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelSignUp.Location = new System.Drawing.Point(231, 65);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(78, 25);
            this.labelSignUp.TabIndex = 7;
            this.labelSignUp.Text = "Sign Up";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(434, 305);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.linkLabelSignIn);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.passwordTextBoxRegister);
            this.Controls.Add(this.emailTextBoxRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "TTH - Register";
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
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
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label labelLogoText;
    }
}

