using Npgsql;
using ReservationAPI.Datasource;
using ReservationAPI.Models;

namespace ReservationAPI.Repositories
{
    public class ReservationRepostitory
    {
        private readonly PostgresDataSource _dataSource;

        public ReservationRepostitory(PostgresDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task<bool> CreateReservation(Reservation reservation)
        {
            string sqlCommand = "INSERT INTO reservations (reservation_id, " +
                "owner_first_name, owner_last_name, owner_id, reservation_total_people," +
                "reservation_start_date, reservation_end_date, created_at) VALUES (" +
                "@reservationId, @ownerFirstName, @ownerLastName, @ownerId," +
                "@reservationTotalPeople, @reservationStartDate, @reservationEndDate," +
                "@createdAt);";

            await _dataSource._dbConnection.OpenAsync();
            await using var cmd = new NpgsqlCommand(sqlCommand, _dataSource._dbConnection);
            cmd.Parameters.AddWithValue("reservationId", reservation.Id);
            cmd.Parameters.AddWithValue("ownerFirstName", reservation.OwnerFirstName);
            cmd.Parameters.AddWithValue("ownerLastName", reservation.OwnerLastName);
            cmd.Parameters.AddWithValue("ownerId", reservation.OwnerId);
            cmd.Parameters.AddWithValue("reservationTotalPeople", reservation.TotalPeople);
            cmd.Parameters.AddWithValue("reservationStartDate", reservation.StartDate);
            cmd.Parameters.AddWithValue("reservationEndDate", reservation.EndDate);
            cmd.Parameters.AddWithValue("createdAt", reservation.CreatedAt);
            var result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }

        public async Task<List<Reservation>> GetAll()
        {
            string sqlQuery = "SELECT reservation_id," +
                "owner_first_name, owner_last_name, owner_id, reservation_total_people," +
                "reservation_start_date, reservation_end_date, created_at " +
                "FROM reservations LIMIT 100;";
            await _dataSource._dbConnection.OpenAsync();
            await using var cmd = new NpgsqlCommand( sqlQuery, _dataSource._dbConnection );
            var result = await cmd.ExecuteNonQueryAsync();

            if( result == 0 )
            {
                return new List<Reservation>();
            }

            await using var reader = await cmd.ExecuteReaderAsync();
            var reservations = new List<Reservation>();
            while(await reader.ReadAsync())
            {
                reservations.Add(new Reservation()
                {
                    Id = reader.GetString(0),
                    OwnerFirstName = reader.GetString(1),
                    OwnerLastName = reader.GetString(2),
                    OwnerId = reader.GetString(3),
                    TotalPeople = reader.GetInt16(4),
                    StartDate = reader.GetDateTime(5),
                    EndDate = reader.GetDateTime(6),
                    CreatedAt = reader.GetDateTime(7),
                });
            }
            return reservations;
        }
    }
}
