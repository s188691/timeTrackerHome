using Firebase.Auth;
using Firebase.Database;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeTrackerHome
{
    class Login //Not working yet ;d
    {
        private string m_AppBaseURL = SensitiveData.APPBASEURL;
        private string m_FirebaseApiKey = SensitiveData.FIREBASEAPIKEY;
        public void LogInUser(FirebaseAuthProvider authProvider, TextBox emialTextBox, TextBox passwordTextBox)
        {
            string email = emialTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                FirebaseAuthProvider m_AuthProvider = new FirebaseAuthProvider(new FirebaseConfig(m_FirebaseApiKey));

                authProvider.SignInWithEmailAndPasswordAsync(email, password);

                emialTextBox.Text = "";
                passwordTextBox.Text = "";

                var firebaseToken = new FirebaseAuth();
                var firebase = new FirebaseClient(m_AppBaseURL, new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(firebaseToken.FirebaseToken)
                });

                var test = authProvider.GetUserAsync(firebaseToken);

                MessageBox.Show(test.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Warrning!");
            }
        }
    }
}
