using MySql.Data.MySqlClient;

namespace Silkroski_C969.Supplemental
{
    public class DbConnection
    {
        #region Properties / Fields

        public static MySqlConnection Connection { get; }

        #endregion

        #region Methods

        public static MySqlConnection InitializeDbConnection()
        {
            var Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        #endregion

        #region Connection String

        private const string _server = "localhost";
        private const string _userName = "test";
        private const string _password = "test";
        private const string _schema = "client_schedule";

        private const string _connectionString = "userid=" + _userName + ";" + "password=" + _password + ";" +
                                                 "database=" + _schema + ";" + "server=" + _server + ";" +
                                                 "allowbatch=True;"; // Replaces MySQLConnectionStringBuilder

        public static string ConnectionString =>
            _connectionString; // Getter-only property keeps connection safe, lambda for ease of reading

        #endregion
    }
}