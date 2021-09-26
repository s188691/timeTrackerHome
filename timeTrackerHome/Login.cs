using Firebase.Auth;
using System;
using System.Windows.Forms;

namespace timeTrackerHome
{
    class Login
    {
        private string m_LoginSuccessful = Consts.LOGINSUCCESSFUL;
        private string m_LoginFailed = Consts.LOGINFAILED;
        public void LogInUser(FirebaseAuthProvider authProvider, TextBox emialTextBox, TextBox passwordTextBox)
        {
            string email = emialTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                var auth = authProvider.SignInWithEmailAndPasswordAsync(email, password);

                emialTextBox.Text = "";
                passwordTextBox.Text = "";

                if (email == auth.Result.User.Email)
                {
                    MessageBox.Show(m_LoginSuccessful);
                }
                else
                {
                    MessageBox.Show(m_LoginFailed);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(m_LoginFailed);
            }
        }
    }
}
