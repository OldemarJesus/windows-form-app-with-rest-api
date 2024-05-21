using Npgsql;
using ReservationAPI.Datasource;
using ReservationAPI.Models;

namespace ReservationAPI.Repositories
{
    public class UserRepository
    {
        private readonly PostgresDataSource _dataSource;

        public UserRepository(PostgresDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task<bool> CreateUser(User user)
        {
            //INSERT INTO "users" ("user_id", "username", "password", "first_name", "last_name", "created_at")
            // VALUES('b977a007-a56d-4ab6-b4b1-401839fb524f', 'oldemar', 'a0yd800ay80ya0y01', 'Oldemar', 'Jesus', '2024-05-20 21:04:18');
            await _dataSource._dbConnection.OpenAsync();
            await using var cmd = new NpgsqlCommand("INSERT INTO users (user_id, username, password, first_name, last_name, created_at) VALUES (@id, @username, @pass, @firstName, @lastName, @createdAt)", _dataSource._dbConnection);
            cmd.Parameters.AddWithValue("id", user.Id);
            cmd.Parameters.AddWithValue("username", user.Username);
            cmd.Parameters.AddWithValue("pass", user.Password);
            cmd.Parameters.AddWithValue("firstName", user.FirstName);
            cmd.Parameters.AddWithValue("lastName", user.LastName);
            cmd.Parameters.AddWithValue("createdAt", user.CreatedAt);
            var result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            String sqlQuery = "SELECT user_id, username, password, first_name, last_name, created_at FROM users u WHERE u.username LIKE @username LIMIT 1;";

            await _dataSource._dbConnection.OpenAsync();
            await using var cmd = new NpgsqlCommand(sqlQuery, _dataSource._dbConnection);
            cmd.Parameters.AddWithValue("username", username);
            var result = await cmd.ExecuteNonQueryAsync();

            // no data found
            if(result == 0 || result > 1)
            {
                return null;
            }

            await using var reader = await cmd.ExecuteReaderAsync();
            while(await  reader.ReadAsync())
            {
                return new User
                {
                    Id = reader.GetString(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    FirstName = reader.GetString(3),
                    LastName = reader.GetString(4),
                    CreatedAt = reader.GetDateTime(5),
                };
            }

            return null;
        }

        public async Task<User?> GetUserById(string id)
        {
            String sqlQuery = "SELECT user_id, username, password, first_name, last_name, created_at FROM users u WHERE u.user_id = @id LIMIT 1;";

            await _dataSource._dbConnection.OpenAsync();
            await using var cmd = new NpgsqlCommand(sqlQuery, _dataSource._dbConnection);
            cmd.Parameters.AddWithValue("id", id);
            var result = await cmd.ExecuteNonQueryAsync();

            // no data found
            if (result == 0 || result > 1)
            {
                return null;
            }

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                return new User
                {
                    Id = reader.GetString(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    FirstName = reader.GetString(3),
                    LastName = reader.GetString(4),
                    CreatedAt = reader.GetDateTime(5),
                };
            }

            return null;
        }


    }
}
