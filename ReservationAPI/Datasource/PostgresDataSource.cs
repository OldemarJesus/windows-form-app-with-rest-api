using Npgsql;

namespace ReservationAPI.Datasource
{
    public class PostgresDataSource
    {
        public NpgsqlConnection _dbConnection { get; private set; }
        public PostgresDataSource(string? connectionString)
        {
            if(connectionString == null || string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("The connection string Default must exists");
            }

            _dbConnection = new NpgsqlConnection(connectionString);
        }
    }
}
