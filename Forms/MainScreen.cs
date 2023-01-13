using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Forms;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969
{
    public partial class MainScreen : Form
    {
        public MainScreen(int loggedInUserId)
        {
            var userId = loggedInUserId;
            InitializeComponent();
            Instance = this;
            var Connection = DbConnection.InitializeDbConnection();
            m_connection = Connection;

            if (Connection.State != ConnectionState.Open) Connection.Open();

            // This should help in a scenario where the auto-increment IDs don't update because of cached data in the connection.
            // The queries will work and write the correct data regardless.
            var cmd = new MySqlCommand("SET @@SESSION.information_schema_stats_expiry = 0;", Connection);
            cmd.ExecuteNonQuery();

            UpcomingApptAlert(userId);
        }

        public static MainScreen Instance { get; private set; }

        public MySqlConnection m_connection { get; }

        #region Alerting

        public void UpcomingApptAlert(int userId)
        {
            if (m_connection != null)
                if (m_connection.State != ConnectionState.Open)
                    m_connection.Open();

            try
            {
                using (m_connection)
                {
                    var autoIncrement = m_connection.CreateCommand();
                    autoIncrement.CommandText = "SET @@SESSION.information_schema_stats_expiry = 0;";
                    autoIncrement.ExecuteNonQuery();

                    var getAppt = m_connection.CreateCommand();
                    getAppt.CommandText = "SELECT title, `description`, customerId, location, " +
                                          "contact, `type`, `start`, `end` FROM appointment WHERE userId = @userId AND `start` BETWEEN SYSDATE() AND DATE_ADD(SYSDATE(), INTERVAL 15 minute) ORDER BY `start`;";
                    getAppt.Parameters.AddWithValue("@userId", userId);
                    getAppt.Parameters.AddWithValue("@currentTime", DateTime.UtcNow);
                    var reader = getAppt.ExecuteReader();
                    while (reader.Read())
                    {
                        var cxId = reader.GetString(0);
                        var title = reader.GetString(1);
                        var desc = reader.GetString(2);
                        var loc = reader.GetString(3);
                        var contact = reader.GetString(4);
                        var type = reader.GetString(5);
                        var start = reader.GetDateTime(6).ToLocalTime();
                        var end = reader.GetDateTime(7).ToLocalTime();
                        new Alert(cxId, title, desc, loc, contact, type, start, end).ShowDialog();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion

        private void EnableOnSelected(object sender, EventArgs e)
        {
            if (sender == appointments_DGV)
            {
                EditApptBtn.Enabled = true;
                DeleteApptBtn.Enabled = true;
            }

            if (sender == customer_DGV)
            {
                EditCxBtn.Enabled = true;
                RemoveCxBtn.Enabled = true;
            }
        }

        private void apptTypesBtn_Click(object sender, EventArgs e)
        {
            var query =
                "SELECT MONTH(start) AS Month, YEAR(start) AS Year, type as 'Appointment Type'," +
                " COUNT(appointmentId) AS 'Appointment Count' FROM appointment" +
                " GROUP BY MONTH(start), YEAR(start), type;";

            new PrintPopup(query).ShowDialog();
        }

        private void scheduleByUserBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(userIdTb.Text, out var userId))
            {
                if (SqlSpecific.DoesItExist("user", "userId", userId.ToString()))
                {
                    var query =
                        "SELECT type as 'Appointment Type', title as 'Appointment Title', customerId as 'Customer #'," +
                        " start as 'Appointment Start', `end` as 'Appointment End' " +
                        "FROM appointment WHERE userId = " + userId + " ORDER BY start desc;";
                    new PrintPopup(query).ShowDialog();
                }
                else
                {
                    MessageBox.Show("The userId you provided was not found.", "Invalid data submission");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid userId - " +
                                "this must be an integer.", "Invalid data submission");
            }
        }

        private void scheduleByCxBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cxIdTb.Text, out var cxId))
            {
                if (SqlSpecific.DoesItExist("customer", "customerId", cxId.ToString()))

                {
                    var query =
                        "SELECT type as 'Appointment Type', title as 'Appointment Title', start as 'Appointment Start'," +
                        " `end` as 'Appointment End', location as 'Appointment Location', userId as 'Employee #'" +
                        " FROM appointment WHERE customerId = " + cxId + " ORDER BY start desc;";
                    new PrintPopup(query).ShowDialog();
                }
                else
                {
                    MessageBox.Show("The customerId you provided was not found.", "Invalid data submission");
                }
            }
            else
            {
                MessageBox.Show("Please enter a customerId - " +
                                "this must be an integer.", "Invalid data submission");
            }
        }

        private void createCityBtn_Click(object sender, EventArgs e)
        {
            var form = new CityForm();
            form.ShowDialog();
            FillFlexDgv("City");
        }

        private void createCountryBtn_Click(object sender, EventArgs e)
        {
            var form = new CountryForm();
            form.ShowDialog();
            FillFlexDgv("Country");
        }

        private void createAddyBtn_Click(object sender, EventArgs e)
        {
            var form = new AddressForm();
            form.ShowDialog();
            FillFlexDgv("Address");
        }

        private void editCityBtn_Click(object sender, EventArgs e)
        {
            var city = IsSelected_alternate_generic<City>(ccaDGV);
            var form = new CityForm(city);
            form.ShowDialog();
            FillFlexDgv("City");
        }

        private void editCountryBtn_Click(object sender, EventArgs e)
        {
            var country = IsSelected_alternate_generic<Country>(ccaDGV);
            var form = new CountryForm(country);
            form.ShowDialog();
            FillFlexDgv("Country");
        }

        private void editAddyBtn_Click(object sender, EventArgs e)
        {
            var address = IsSelected_alternate_generic<Address>(ccaDGV);
            var form = new AddressForm(address);
            form.ShowDialog();
            FillFlexDgv("Address");
        }

        private void removeCityBtn_Click(object sender, EventArgs e)
        {
            var length = IsSelected_alternate_generic<City>(ccaDGV);
            if (length != null)
            {
                var city = IsSelected_alternate_generic<City>(ccaDGV);
                SqlSpecific.CityRemoved(city.CityId);
                RefreshData();
                FillFlexDgv("City");
            }
            else
            {
                MessageBox.Show("You must select a city first.", "Selection error");
            }
        }

        private void removeCountryBtn_Click(object sender, EventArgs e)
        {
            var length = IsSelected_alternate_generic<Country>(ccaDGV);
            if (length != null)
            {
                var country = IsSelected_alternate_generic<Country>(ccaDGV);
                SqlSpecific.CountryRemoved(country.CountryId);
                RefreshData();
                FillFlexDgv("Country");
            }
            else
            {
                MessageBox.Show("You must select a country first.", "Selection error");
            }
        }

        private void removeAddyBtn_Click(object sender, EventArgs e)
        {
            var length = IsSelected_alternate_generic<Address>(ccaDGV);
            if (length != null)
            {
                var address = IsSelected_alternate_generic<Address>(ccaDGV);
                SqlSpecific.AddressRemoved(address.AddressId);
                RefreshData();
                FillFlexDgv("Address");
            }
            else
            {
                MessageBox.Show("You must select an address first.", "Selection error");
            }
        }

        private void LoadDatabtn_Click(object sender, EventArgs e)
        {
            RefreshData();
            LoadDatabtn.Visible = false;
        }

        #region Button Functions

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void alertCheckerBtn_Click(object sender, EventArgs e)
        {
            var tbContent = alertUserIdTb.Text;
            if (int.TryParse(tbContent, out var userId))
            {
                if (SqlSpecific.DoesItExist("user", "userId", tbContent))
                    UpcomingApptAlert(userId);
                else
                    MessageBox.Show("Please enter a valid userId to check for upcoming appointments.",
                        "Unable to locate User");
            }
        }

        private void FullViewBtn_Click(object sender, EventArgs e)
        {
            PopulateAppointments();
        }

        private void CreateCxBtn_Click(object sender, EventArgs e)
        {
            PopulateCustomers();
            var customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void WeekViewBtn_Click(object sender, EventArgs e)
        {
            PopulateAppointments("WHERE (WEEK(start) = WEEK(CURDATE())) AND (YEAR(start) = YEAR(CURDATE()))");
        }

        private void MonthViewBtn_Click(object sender, EventArgs e)
        {
            PopulateAppointments("WHERE (MONTH(start) = MONTH(CURDATE())) AND (YEAR(start) = YEAR(CURDATE()))");
        }

        private void UpdateCxBtn_Click(object sender, EventArgs e)
        {
            UpdateCx();
        }

        private void CreateApptBtn_Click(object sender, EventArgs e)
        {
            PopulateAppointments();
            var form = new AppointmentForm(this);
            form.ShowDialog();
            RefreshData();
        }

        private void EditApptBtn_Click(object sender, EventArgs e)
        {
            // PopulateAppointments();
            var appointment = IsSelected_alternate_generic<Appointment>(appointments_DGV);
            var form = new AppointmentForm(appointment);
            form.ShowDialog();
            RefreshData();
        }

        private void DeleteApptBtn_Click(object sender, EventArgs e)
        {
            PopulateAppointments();
            if (IsSelected_alternate_generic<Appointment>(appointments_DGV).ToString().Length > 0)
            {
                var appointment = IsSelected_alternate_generic<Appointment>(appointments_DGV);
                SqlSpecific.AppointmentRemoved(appointment.AppointmentId);
                RefreshData();
            }
            else
            {
                MessageBox.Show("You must select an appointment first.", "Selection error");
            }
        }

        private void RemoveCxBtn_Click(object sender, EventArgs e)
        {
            PopulateCustomers();
            if (IsSelected_alternate_generic<Customer>(customer_DGV).ToString().Length > 0)
            {
                var customer = IsSelected_alternate_generic<Customer>(customer_DGV);
                SqlSpecific.CustomerRemoved(customer.CustomerId);
                RefreshData();
            }
            else
            {
                MessageBox.Show("You must select a customer first.", "Selection error");
            }
        }

        private void viewCityBtn_Click(object sender, EventArgs e)
        {
            disableAddyBtns();
            disableCountryBtns();
            enableCityBtns();
            viewingLbl.Text = "Viewing: Cities";
            FillFlexDgv("City");
        }

        private void viewCountryBtn_Click(object sender, EventArgs e)
        {
            disableCityBtns();
            disableAddyBtns();
            enableCountryBtns();
            viewingLbl.Text = "Viewing: Countries";
            FillFlexDgv("Country");
        }

        private void viewAddyBtn_Click(object sender, EventArgs e)
        {
            disableCityBtns();
            disableCountryBtns();
            enableAddyBtns();
            viewingLbl.Text = "Viewing: Addresses";
            FillFlexDgv("Address");
        }

        #endregion

        #region Functions

        private void Logout()
        {
            var ls = new LoginScreen();
            if (m_connection.State == ConnectionState.Open) m_connection.Dispose();
            ls.Show();
        }

        private void UpdateCx()
        {
            var customer = IsSelected_alternate_generic<Customer>(customer_DGV);
            var form = new CustomerForm(customer);
            form.ShowDialog();
        }

        private T IsSelected_alternate_generic<T>(DataGridView dgvToCheck) where T : class
        {
            if (dgvToCheck.SelectedRows.Count == 0) return null;

            var selectedRowTag = dgvToCheck.SelectedRows[0].Tag as T;
            return selectedRowTag;
        }

        private void disableAddyBtns()
        {
            createAddyBtn.Enabled = false;
            editAddyBtn.Enabled = false;
            removeAddyBtn.Enabled = false;
        }

        private void disableCityBtns()
        {
            createCityBtn.Enabled = false;
            editCityBtn.Enabled = false;
            removeCityBtn.Enabled = false;
        }

        private void disableCountryBtns()
        {
            createCountryBtn.Enabled = false;
            editCountryBtn.Enabled = false;
            removeCountryBtn.Enabled = false;
        }

        private void enableAddyBtns()
        {
            createAddyBtn.Enabled = true;
            editAddyBtn.Enabled = true;
            removeAddyBtn.Enabled = true;
        }

        private void enableCityBtns()
        {
            createCityBtn.Enabled = true;
            editCityBtn.Enabled = true;
            removeCityBtn.Enabled = true;
        }

        private void enableCountryBtns()
        {
            createCountryBtn.Enabled = true;
            editCountryBtn.Enabled = true;
            removeCountryBtn.Enabled = true;
        }

        private void RefreshData()
        {
            PopulateCustomers();
            PopulateAppointments();
        }

        private void FillFlexDgv(string type)
        {
            try
            {
                using (m_connection)
                {
                    string query;

                    switch (type)
                    {
                        case "Country":
                            query = "SELECT * from country ORDER by countryId;";
                            populateDataGridView<Country>(query, ccaDGV);
                            break;
                        case "City":
                            query = "SELECT * from city ORDER by city, cityId, countryId;";
                            populateDataGridView<City>(query, ccaDGV);
                            break;
                        case "Address":
                            query = "SELECT * from address ORDER by addressId, cityId, address;";
                            populateDataGridView<Address>(query, ccaDGV);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered when loading view: " + e);
            }
        }

        private void populateDataGridView<T>(string sqlSelectAll, DataGridView dgvParam) where T : BaseModel, new()
        {
            var MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, m_connection);
            var workingDataTable = new DataTable();
            var workingBindingSource = new BindingSource();

            //Start
            MyDA.Fill(workingDataTable);

            var workingList = new List<T>();
            foreach (DataRow curRow in workingDataTable.Rows)
            {
                var nextItem = new T();
                foreach (DataColumn curColumn in workingDataTable.Columns)
                foreach (var curProperty in nextItem.GetType().GetProperties())
                {
                    var mainAttributes = curProperty
                        .GetCustomAttributes(typeof(Generic_Attribute), false)
                        .Cast<Generic_Attribute>();
                    if (!mainAttributes.Any())
                    {
                        Console.WriteLine("List is empty.");
                        break;
                    }

                    var columnNameFromAttribute = mainAttributes.First().ColumnName;

                    if (columnNameFromAttribute == curColumn.ColumnName)
                    {
                        var curRowValue = curRow[curColumn.ColumnName];

                        if (curRowValue is bool)
                        {
                            var intValue = Convert.ToInt32(curRowValue);
                            curProperty.SetValue(nextItem, intValue);
                        }
                        else
                        {
                            curProperty.SetValue(nextItem, curRowValue);
                        }

                        break;
                    }
                }

                workingList.Add(nextItem);
            }

            var primaryKeyColName = new T().GetPrimaryKeyColumnName();

            workingBindingSource.DataSource = workingDataTable;

            dgvParam.DataSource = workingBindingSource;

            foreach (DataGridViewRow curRow in dgvParam.Rows)
            {
                if (curRow.Cells[primaryKeyColName].Value is null) continue;

                var matchingObjects =
                    workingList.Where(currentItem =>
                        currentItem.GetPrimaryKeyValue().ToString() ==
                        curRow.Cells[primaryKeyColName].Value.ToString());

                if (!matchingObjects.Any())
                {
                    Console.WriteLine("No matching column names found.");
                    break;
                }

                var firstObject = matchingObjects.First();
                if (firstObject == null) break;
                curRow.Tag = firstObject;
            }
        }


        private void PopulateAppointments(string where_clause = "")
        {
            {
                //Define variables
                var sqlSelectAll =
                    "SELECT a.*, c.customerName, u.userName FROM appointment AS a JOIN customer AS c ON a.customerId = c.customerId JOIN user AS u ON u.userId = a.userId ";
                if (!string.IsNullOrEmpty(where_clause)) sqlSelectAll += where_clause;

                sqlSelectAll += " order by a.start;";

                populateDataGridView<Appointment>(sqlSelectAll, appointments_DGV);
            }
        }

        private void PopulateCustomers(string where_clause = "")
        {
            var sqlSelectAll = "SELECT customerName, customerId, addressId FROM customer";
            if (!string.IsNullOrEmpty(where_clause)) sqlSelectAll += where_clause;
            sqlSelectAll += " order by customerName;";
            populateDataGridView<Customer>(sqlSelectAll, customer_DGV);
        }

        #endregion
    }
}