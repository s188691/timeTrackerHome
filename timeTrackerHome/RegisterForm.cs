using Firebase.Auth;
using System.Windows.Forms;

namespace timeTrackerHome
{
    public partial class RegisterForm : Form
    {
        private string m_FirebaseApiKey = SensitiveData.FIREBASEAPIKEY;
        private FirebaseAuthProvider m_AuthProvider;

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            m_AuthProvider = new FirebaseAuthProvider(new FirebaseConfig(m_FirebaseApiKey));
            createAccountBtn.Text = Consts.CREATEACCOUNTBTN;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.SignUpNewUser(m_AuthProvider, emailTextBoxRegister, passwordTextBoxRegister);
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/s188691/timeTrackerHome");
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelSignIn.LinkVisited = true;
            Form loginForm = new LoginForm();
            this.Hide();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            this.Close();
        }
    }
}


//private string m_GithubAccessToken = SensitiveData.GITHUBSECRET;
//private string m_AppBaseURL = SensitiveData.APPBASEURL;
//var auth = authProvider.SignInWithEmailAndPasswordAsync(m_Email, m_Password);
//var firebaseToken = new FirebaseAuth();
//var firebase = new FirebaseClient(m_AppBaseURL, new FirebaseOptions
//{
//    AuthTokenAsyncFactory = () => Task.FromResult(firebaseToken.FirebaseToken)
//});