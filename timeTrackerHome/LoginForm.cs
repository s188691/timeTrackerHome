using Firebase.Auth;
using System.Windows.Forms;

namespace timeTrackerHome
{
    public partial class LoginForm : Form
    {
        private string m_FirebaseApiKey = SensitiveData.FIREBASEAPIKEY;
        private FirebaseAuthProvider m_AuthProvider;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            m_AuthProvider = new FirebaseAuthProvider(new FirebaseConfig(m_FirebaseApiKey));
            loginAccountBtn.Text = Consts.LOGINBTN;
        }
        private void loginAccountBtn_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();
            login.LogInUser(m_AuthProvider, emailTextBoxLogin, passwordTextBoxLogin);
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelSignUp.LinkVisited = true;
            Form registerForm = new RegisterForm();
            this.Hide();
            registerForm.StartPosition = FormStartPosition.CenterScreen;
            registerForm.ShowDialog();
            this.Close();
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/s188691/timeTrackerHome");
        }
    }
}
