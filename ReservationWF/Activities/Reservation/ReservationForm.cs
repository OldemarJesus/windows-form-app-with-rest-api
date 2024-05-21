using ReservationWF.Activities.Auth;
using ReservationWF.Activities.Reservation;
using ReservationWF.Models;
using ReservationWF.Services;

namespace ReservationWF
{
    public partial class ReservationForm : Form
    {
        private readonly LoginActivity _loginActivity;
        private readonly string _loginToken;

        public ReservationForm(LoginActivity loginActivity, string loginToken)
        {
            InitializeComponent();
            _loginActivity = loginActivity;
            _loginToken = loginToken;
            fillUserProfile();
        }

        private void onClearBtnClick(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            // clear the forms input
            this.firstNameTxt.Text = string.Empty;
            this.lastNameTxt.Text = string.Empty;
            this.totalPeopleTxt.Value = 0;

            // put the cursor in first name input
            this.firstNameTxt.Focus();
        }

        private void onLogoutBtnClick(object sender, EventArgs e)
        {
            this.Close();
            _loginActivity.Show();
        }

        private async void fillUserProfile()
        {
            UserService service = new UserService(_loginToken);
            UserProfile? userProfile = await service.GetProfileInfo();

            if (userProfile == null)
            {
                MessageBox.Show("Unable to load user profile.");
                return;
            }

            this.authenticatedUserTxt.Text = userProfile.FirstName + " " + userProfile.LastName;
        }

        private async void onSaveBtnClick(object sender, EventArgs e)
        {
            string firstName = this.firstNameTxt.Text;
            string lastName = this.lastNameTxt.Text;
            int totalPeople = (int)this.totalPeopleTxt.Value;
            DateTime startDate = this.startDateDtp.Value;
            DateTime endDate = this.endDateDtp.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("None of fields should be empty");
                this.firstNameTxt.Focus();
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("The start date must be before end date");
                this.startDateDtp.Focus();
                return;
            }

            var reservation = new ReservationInfo
            {
                OwnerFirstName = firstName,
                OwnerLastName = lastName,
                TotalPeople = totalPeople,
                StartDate = startDate,
                EndDate = endDate
            };

            ReservationService service = new ReservationService(_loginToken);
            var result = await service.CreateReservation(reservation);

            if (result == null)
            {
                MessageBox.Show("The reservation creation failed.");
                return;
            }

            MessageBox.Show("The reservation was created with id: " + result);
            clearForm();
        }

        private void onListBtnClick(object sender, EventArgs e)
        {
            var reservationListActivity = new ReservationList(_loginActivity, _loginToken);
            this.Close();
            reservationListActivity.Show();
        }
    }
}
