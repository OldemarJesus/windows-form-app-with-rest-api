
using ReservationWF.Activities.Auth;
using ReservationWF.Services;

namespace ReservationWF.Activities.Reservation
{
    public partial class ReservationList : Form
    {
        private readonly LoginActivity _loginActivity;
        private readonly string _loginToken;
        private readonly DataGridView reservationDgvInstance;
        public ReservationList(LoginActivity loginActivity, string loginToken)
        {
            this._loginToken = loginToken;
            this._loginActivity = loginActivity;
            InitializeComponent();
            reservationDgvInstance = this.reservationListDgv;
            SetupListView();
            PopulateDataGridView();
        }

        private void SetupListView()
        {
            this.Controls.Add(reservationDgvInstance);
            reservationDgvInstance.ColumnCount = 4;

            reservationDgvInstance.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            reservationDgvInstance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            reservationDgvInstance.ColumnHeadersDefaultCellStyle.Font =
                new Font(reservationDgvInstance.Font, FontStyle.Bold);

            reservationDgvInstance.Name = "Reservation List";

            reservationDgvInstance.Columns[0].Name = "ID";
            reservationDgvInstance.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDgvInstance.Columns[1].Name = "Start Date";
            reservationDgvInstance.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDgvInstance.Columns[2].Name = "End Date";
            reservationDgvInstance.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDgvInstance.Columns[3].Name = "Owner Name";
            reservationDgvInstance.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDgvInstance.Columns[3].DefaultCellStyle.Font =
                new Font(reservationDgvInstance.DefaultCellStyle.Font, FontStyle.Italic);

            reservationDgvInstance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            reservationDgvInstance.MultiSelect = false;
        }

        private async void PopulateDataGridView()
        {
            ReservationService service = new ReservationService(_loginToken);
            var reservations = await service.GetAll();

            if(reservations == null)
            {
                MessageBox.Show("No reservation found.");
                return;
            }

            int counter = 0;
            foreach( var reservation in reservations)
            {
                string[] row = { 
                    reservation.Id, 
                    reservation.StartDate.ToString(), 
                    reservation.EndDate.ToString(),
                    reservation.OwnerFirstName
                };

                reservationDgvInstance.Rows.Add(row);
                reservationDgvInstance.Columns[counter].DisplayIndex = counter;
                counter++;
            }
        }

        private void onCreateBtnClick(object sender, EventArgs e)
        {
            var reservationCreateActivity = new ReservationForm(_loginActivity, _loginToken);
            this.Close();
            reservationCreateActivity.Show();
        }

        private void onLogoutBtnClick(object sender, EventArgs e)
        {
            this.Close();
            _loginActivity.Show();
        }
    }
}
