using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class PrintPopup : Form
    {
        public PrintPopup(string query) // Constructor for number of appt types per month - Req I1
        {
            InitializeComponent();
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            connection.Open();

            var command = new MySqlCommand(query, connection);
            var dataToFillTable = new DataTable();
            dataToFillTable.Load(command.ExecuteReader());
            popupDGV.DataSource = dataToFillTable;
        }

        public PrintPopup(MySqlCommand command) // Constructor for schedule per customer - Req I1,2,3
        {
            InitializeComponent();
            var connection = DbConnection.Connection;
            connection.Open();

            var dataToFillTable = new DataTable();
            dataToFillTable.Load(command.ExecuteReader());
            popupDGV.DataSource = dataToFillTable;
        }
    }
}