using ReservationWF.Services.Auth;

namespace ReservationWF.Activities.Auth
{
    public partial class LoginActivity : Form
    {
        public LoginActivity()
        {
            InitializeComponent();
        }

        public void onRegisterBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisterActivity activity = new RegisterActivity(this);
            activity.ShowDialog();
        }

        private async void onLoginBtnClick(object sender, EventArgs e)
        {
            try
            {
                // verify form field
                if (string.IsNullOrEmpty(this.passwordInputTxt.Text) || string.IsNullOrEmpty(this.usernameInputTxt.Text))
                {
                    MessageBox.Show("Fields cannot be empty");
                    return;
                }

                LoginService loginService = new LoginService();
                var token =  await loginService.GetToken(this.usernameInputTxt.Text, this.passwordInputTxt.Text);

                if (token == null || string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Login Failed!");
                    return;
                }

                this.Hide();
                ReservationForm activity = new ReservationForm(this, token);
                activity.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
