using ReservationWF.Models;
using ReservationWF.Services.Auth;

namespace ReservationWF.Activities.Auth
{
    public partial class RegisterActivity : Form
    {
        private LoginActivity acitveLoginActivity;

        public RegisterActivity(LoginActivity acitveLoginActivity)
        {
            InitializeComponent();
            this.acitveLoginActivity = acitveLoginActivity;
        }

        private void onClearBtnClick(object sender, EventArgs e)
        {
            // clear forms input
            this.firstNameInputTxt.Text = string.Empty;
            this.lastNameInputTxt.Text = string.Empty;
            this.passwordInputTxt.Text = string.Empty;
            this.usernameInputTxt.Text = string.Empty;

            // set focus on first input
            this.firstNameInputTxt.Focus();
        }

        private void onLoginBtnClick(object sender, EventArgs e)
        {
            this.Close();
            acitveLoginActivity.Show();
        }

        private async void onRegisterBtnClick(object sender, EventArgs e)
        {
            string firstName = this.firstNameInputTxt.Text;
            string lastName = this.lastNameInputTxt.Text;
            string password = this.passwordInputTxt.Text;
            string username = this.usernameInputTxt.Text;

            if(
                firstName == string.Empty ||
                lastName == string.Empty ||
                password == string.Empty ||
                username == string.Empty)
            {
                MessageBox.Show("None of the fields can be empty.");
                return;
            }

            UserInfo userInfo = new UserInfo
            {
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Username = username
            };
            RegisterService registerService = new RegisterService();
            var result = await registerService.RegisterUser(userInfo);

            if(result == null || string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Failed to create user.");
                return;
            }

            ReservationForm activity = new ReservationForm(acitveLoginActivity, result);
            this.Close();
            activity.ShowDialog();
        }
    }
}
