using Firebase.Auth;
using System;
using System.Windows.Forms;

namespace timeTrackerHome
{
    class SignUp
    {
        private string m_Success = Consts.SIGNUPSUCCESSFUL;
        private string m_Fail = Consts.SIGNUPFAILED;
        public void SignUpNewUser(FirebaseAuthProvider authProvider, TextBox emialTextBox, TextBox passwordTextBox)
        {
            //TODO
            //Check if user provided correct data

            string email = emialTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                authProvider.CreateUserWithEmailAndPasswordAsync(email, password, sendVerificationEmail: true);

                emialTextBox.Text = "";
                passwordTextBox.Text = "";

                MessageBox.Show(m_Success);
            }
            catch (Exception)
            {
                MessageBox.Show(m_Fail);
            }
        }
    }
}
