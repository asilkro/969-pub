using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;

namespace Silkroski_C969.Supplemental
{
    public abstract class SqlSpecific
    {
        #region Inserts

        public static bool CustomerInserted(Customer customer)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var customerInserted = false;
            switch (CustomerExists(customer.CustomerName, customer.AddressId))
            {
                case true:
                    return customerInserted;
                case false:
                    try
                    {
                        connection.Open();
                        var insert = connection.CreateCommand();
                        insert.CommandText =
                            "INSERT INTO customer (customerName, addressId, active, createdBy, createDate, lastUpdateBy, lastUpdate) " +
                            "VALUES (@cxName, @addressId, @active, @createdBy, @createDate, @lastUpdateBy, @lastUpdate)";
                        insert.Parameters.AddWithValue("@cxName", customer.CustomerName);
                        insert.Parameters.AddWithValue("@addressId", customer.AddressId);
                        insert.Parameters.AddWithValue("@active", 1); //Adding someone that can't be used seems silly
                        insert.Parameters.AddWithValue("@createdBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);

                        if (insert.ExecuteNonQuery() == 1)
                        {
                            customerInserted = true;
                            MessageBox.Show("Customer named " + customer.CustomerName + " was added.",
                                "Customer Added");
                        }
                        else
                        {
                            MessageBox.Show("Unable to add customer.", "Customer not added.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception thrown while inserting customer: " + e);
                        customerInserted = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return customerInserted;
            }

            return customerInserted;
        }

        public static bool AppointmentInserted(Appointment appointment)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var appointmentInserted = false;
            var uniStart = appointment.Start.ToUniversalTime();
            var uniEnd = appointment.End.ToUniversalTime();

            switch (DoAppointmentsOverlap(uniStart, uniEnd))
            {
                case true:
                    return appointmentInserted;
                case false:
                    try
                    {
                        connection.Open();
                        var insert = connection.CreateCommand();
                        insert.CommandText =
                            "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createdBy, createDate, lastUpdateBy, lastUpdate) " +
                            "VALUES(@cxId, @userId, @title, @desc, @loc, @contact, @type, @url, @start, @end, @createdBy, @createDate, @lastUpdateBy, @lastUpdate)";
                        insert.Parameters.AddWithValue("@userId", appointment.UserId);
                        insert.Parameters.AddWithValue("@cxId", appointment.CustomerId);
                        insert.Parameters.AddWithValue("@title", appointment.Title);
                        insert.Parameters.AddWithValue("@desc", appointment.Description);
                        insert.Parameters.AddWithValue("@loc", appointment.Location);
                        insert.Parameters.AddWithValue("@type", appointment.Type);
                        insert.Parameters.AddWithValue("@url", appointment.Url);
                        insert.Parameters.AddWithValue("@start", uniStart);
                        insert.Parameters.AddWithValue("@end", uniEnd);
                        insert.Parameters.AddWithValue("@contact", appointment.Contact);
                        insert.Parameters.AddWithValue("@createdBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);

                        if (!DoAppointmentsOverlap(uniStart, uniEnd))
                            if (insert.ExecuteNonQuery() == 1)
                            {
                                appointmentInserted = true;
                                MessageBox.Show(
                                    "Appointment at " + appointment.Start.TimeOfDay +
                                    " was added.", "Appointment Added");
                            }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Exception thrown while inserting appointment: " + e);
                        appointmentInserted = false;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return appointmentInserted;
            }

            return appointmentInserted;
        }

        public static bool CityInserted(City cityToInsert)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var cityInserted = false;
            switch (CityExists(cityToInsert.CityName, cityToInsert.CountryId))
            {
                case true:
                    MessageBox.Show("The city: " + cityToInsert.CityName + " already exists.", "Error: City exists");
                    return cityInserted;
                case false:
                    try
                    {
                        connection.Open();
                        var insert = connection.CreateCommand();
                        insert.CommandText =
                            "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            "VALUES(@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                        insert.Parameters.AddWithValue("@city", cityToInsert.CityName);
                        insert.Parameters.AddWithValue("@countryId", cityToInsert.CountryId);
                        insert.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@createdBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");

                        if (insert.ExecuteNonQuery() == 1)
                        {
                            cityInserted = true;
                            MessageBox.Show("City with name " + cityToInsert.CityName + " was added.", "City Added");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error inserting city: " + e);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return cityInserted;
            }

            return cityInserted;
        }

        public static bool CountryInserted(Country countryToInsert)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var countryInserted = false;
            switch (CountryExists(countryToInsert.Country1))
            {
                case true:
                    MessageBox.Show("The country: " + countryToInsert.Country1 + " already exists.",
                        "Error: Country exists");
                    return countryInserted;
                case false:
                    try
                    {
                        connection.Open();
                        var insert = connection.CreateCommand();
                        insert.CommandText =
                            "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            "VALUES(@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                        insert.Parameters.AddWithValue("@country", countryToInsert.Country1);
                        insert.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@createdBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");

                        if (insert.ExecuteNonQuery() == 1)
                        {
                            countryInserted = true;
                            MessageBox.Show("Country with name " + countryToInsert.Country1 + " was added.",
                                "Country Added");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error inserting Country: " + e);
                        countryInserted = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return countryInserted;
            }

            return countryInserted;
        }

        public static bool AddressInserted(Address addressToInsert)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var addressInserted = false;
            switch (AddressExists(addressToInsert.Address1, addressToInsert.CityId))
            {
                case true:
                    MessageBox.Show("The address: " + addressToInsert.Address1 + " already exists in that city.",
                        "Error: Address exists");
                    return addressInserted;
                case false:
                    try
                    {
                        connection.Open();
                        var insert = connection.CreateCommand();
                        insert.CommandText =
                            "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            "VALUES(@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                        insert.Parameters.AddWithValue("@address", addressToInsert.Address1);
                        insert.Parameters.AddWithValue("@address2", addressToInsert.Address2);
                        insert.Parameters.AddWithValue("@cityId", addressToInsert.CityId);
                        insert.Parameters.AddWithValue("@postalCode", addressToInsert.PostalCode);
                        insert.Parameters.AddWithValue("@phone", addressToInsert.Phone);
                        insert.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@createdBy", "Schedule Software");
                        insert.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                        insert.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");

                        if (insert.ExecuteNonQuery() == 1)
                        {
                            addressInserted = true;
                            MessageBox.Show("Address at " + addressToInsert.Address1 + " was added.", "Address Added");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error inserting address: " + e);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return addressInserted;
            }

            return addressInserted;
        }

        #endregion

        #region Updates

        public static bool CustomerUpdated(Customer cxBeingUpdated)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var cxUpdated = false;
            try
            {
                connection.Open();
                var update = connection.CreateCommand();
                update.CommandText =
                    "UPDATE customer SET customerName = @cxName, addressId = @addressId, active = @active, " +
                    "lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy  " +
                    "WHERE customerId = @cxId";
                update.Parameters.AddWithValue("@cxName", cxBeingUpdated.CustomerName);
                update.Parameters.AddWithValue("@addressId", cxBeingUpdated.AddressId);
                update.Parameters.AddWithValue("@active", 1); // Customers are active
                update.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                update.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                update.Parameters.AddWithValue("@cxId", cxBeingUpdated.CustomerId);

                if (!DoesItExist("customer", "customerName", cxBeingUpdated.CustomerName))
                    if (!DoesItExist("customer", "addressId", cxBeingUpdated.AddressId.ToString()))
                        if (update.ExecuteNonQuery() == 1)
                            cxUpdated = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown while updating customer: " + e);
                cxUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return cxUpdated;
        }

        public static bool AppointmentUpdated(Appointment apptBeingUpdated)
        {
            var appointmentUpdated = false;
            var uniStart = apptBeingUpdated.Start.ToUniversalTime();
            var uniEnd = apptBeingUpdated.End.ToUniversalTime();
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            switch (DoAppointmentsOverlap(uniStart, uniEnd))
            {
                case true:
                    return appointmentUpdated;
                case false:
                    try
                    {
                        connection.Open();
                        var update = connection.CreateCommand();
                        update.CommandText =
                            "UPDATE appointment SET userId = @userId, customerId = @cxId, title = @title," +
                            " description = @desc, location = @loc, type = @type, url = @url," +
                            " start = @start, end = @end, contact = @contact, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy " +
                            " WHERE appointmentId = @apptId";
                        update.Parameters.AddWithValue("@userId", apptBeingUpdated.UserId);
                        update.Parameters.AddWithValue("@cxId", apptBeingUpdated.CustomerId);
                        update.Parameters.AddWithValue("@title", apptBeingUpdated.Title);
                        update.Parameters.AddWithValue("@desc", apptBeingUpdated.Description);
                        update.Parameters.AddWithValue("@loc", apptBeingUpdated.Location);
                        update.Parameters.AddWithValue("@type", apptBeingUpdated.Type);
                        update.Parameters.AddWithValue("@url", apptBeingUpdated.Url);
                        update.Parameters.AddWithValue("@start", uniStart);
                        update.Parameters.AddWithValue("@end", uniEnd);
                        update.Parameters.AddWithValue("@contact", apptBeingUpdated.Contact);
                        update.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                        update.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                        update.Parameters.AddWithValue("@apptId", apptBeingUpdated.AppointmentId);

                        if (update.ExecuteNonQuery() == 1)
                        {
                            appointmentUpdated = true;
                            MessageBox.Show("Appointment with id " + apptBeingUpdated.AppointmentId + " was updated.",
                                "Appointment Updated");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception thrown while updating appointment: " + e);
                        appointmentUpdated = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return appointmentUpdated;
            }

            return appointmentUpdated;
        }

        public static bool AddressUpdated(Address addressBeingUpdated)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var addressUpdated = false;
            try
            {
                connection.Open();
                var update = connection.CreateCommand();

                update.CommandText = "UPDATE address SET address = @address, address2 = @address2, cityId = @cityId," +
                                     " postalCode = @postalCode, phone = @phone, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy " +
                                     "WHERE addressId = @addressId";
                update.Parameters.AddWithValue("@address", addressBeingUpdated.Address1);
                update.Parameters.AddWithValue("@address2", addressBeingUpdated.Address2);
                update.Parameters.AddWithValue("@cityId", addressBeingUpdated.CityId);
                update.Parameters.AddWithValue("@postalCode", addressBeingUpdated.PostalCode);
                update.Parameters.AddWithValue("@phone", addressBeingUpdated.Phone);
                update.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                update.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                update.Parameters.AddWithValue("@addressId", addressBeingUpdated.AddressId.ToString());

                if (update.ExecuteNonQuery() == 1)
                {
                    addressUpdated = true;
                    MessageBox.Show("Address with id " + addressBeingUpdated.AddressId + " was updated.",
                        "Address Updated");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error updating the Address: " + e);
                addressUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return addressUpdated;
        }

        public static bool CityUpdated(City cityBeingUpdated)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var cityUpdated = false;

            try
            {
                connection.Open();
                var update = connection.CreateCommand();
                update.CommandText =
                    "UPDATE city SET city = @cityName, countryId = @countryId, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy " +
                    "WHERE cityId = @cityId";
                update.Parameters.AddWithValue("@cityName", cityBeingUpdated.CityName);
                update.Parameters.AddWithValue("@countryId", cityBeingUpdated.CountryId);
                update.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                update.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");
                update.Parameters.AddWithValue("@cityId", cityBeingUpdated.CityId);

                if (!DoesItExist("city", "city", cityBeingUpdated.CityName))
                    if (update.ExecuteNonQuery() == 1)
                    {
                        cityUpdated = true;
                        MessageBox.Show("City with id " + cityBeingUpdated.CityId + " was updated.", "City Updated");
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error updating the City: " + e);
                cityUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return cityUpdated;
        }

        public static bool CountryUpdated(Country countryBeingUpdated)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            var countryUpdated = false;
            try
            {
                connection.Open();
                var update = connection.CreateCommand();
                update.CommandText =
                    "UPDATE country SET country = @country, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy  " +
                    "WHERE countryId = @countryId";
                update.Parameters.AddWithValue("@country", countryBeingUpdated.Country1);
                update.Parameters.AddWithValue("@countryId", countryBeingUpdated.CountryId);
                update.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                update.Parameters.AddWithValue("@lastUpdateBy", "Schedule Software");

                if (DoesItExist("country", "country", countryBeingUpdated.Country1)) return countryUpdated;
                if (update.ExecuteNonQuery() == 1)
                {
                    countryUpdated = true;
                    MessageBox.Show("Country with id " + countryBeingUpdated.CountryId + " was updated.",
                        "Country Updated");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error updating the Country: " + e);
                countryUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return countryUpdated;
        }

        #endregion

        #region Removals

        public static bool CustomerRemoved(int cxId)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var customerRemoved = false;

            if (WillOrphanRows("appointment", "customerId", cxId.ToString())) return customerRemoved;
            try
            {
                connection.Open();
                var remove = connection.CreateCommand();
                remove.CommandText = "DELETE FROM customer WHERE customerId = @customerId";
                remove.Parameters.AddWithValue("@customerId", cxId);
                remove.ExecuteNonQuery();
                customerRemoved = true;
                MessageBox.Show("Customer removed successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting customer: " + e);
                customerRemoved = false;
            }
            finally
            {
                connection.Close();
            }

            return customerRemoved;
        }

        public static bool AppointmentRemoved(int apptId)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var appointmentRemoved = false;
            try
            {
                connection.Open();
                var remove = connection.CreateCommand();
                remove.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                remove.Parameters.AddWithValue("@appointmentId", apptId);
                remove.ExecuteNonQuery();
                appointmentRemoved = true;
                MessageBox.Show("Appointment removed successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting appointment: " + e);
                appointmentRemoved = false;
            }
            finally
            {
                connection.Close();
            }

            return appointmentRemoved;
        }

        public static bool AddressRemoved(int addressId)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var addressRemoved = false;
            if (!WillOrphanRows("customer", "addressId", addressId.ToString()))
                try
                {
                    connection.Open();
                    var remove = connection.CreateCommand();
                    remove.CommandText = "DELETE FROM address WHERE addressId = @addressId";
                    remove.Parameters.AddWithValue("@addressId", addressId);
                    remove.ExecuteNonQuery();
                    addressRemoved = true;
                    MessageBox.Show("Address removed successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error deleting address: " + e);
                    return addressRemoved;
                }
                finally
                {
                    connection.Close();
                }

            return addressRemoved;
        }

        public static bool CityRemoved(int cityId)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var cityRemoved = false;
            if (!WillOrphanRows("address", "cityId", cityId.ToString()))
                try
                {
                    connection.Open();
                    var remove = connection.CreateCommand();
                    remove.CommandText = "DELETE FROM city WHERE cityId = @cityId";
                    remove.Parameters.AddWithValue("@cityId", cityId);
                    remove.ExecuteNonQuery();
                    cityRemoved = true;
                    MessageBox.Show("City removed successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error deleting City: " + e);
                    cityRemoved = false;
                }
                finally
                {
                    connection.Close();
                }

            return cityRemoved;
        }

        public static bool CountryRemoved(int countryId)
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var countryRemoved = false;
            if (!WillOrphanRows("city", "countryId", countryId.ToString()))
                try
                {
                    connection.Open();
                    var remove = connection.CreateCommand();
                    remove.CommandText = "DELETE FROM country WHERE countryId = @countryId";
                    remove.Parameters.AddWithValue("@countryId", countryId);
                    remove.ExecuteNonQuery();
                    countryRemoved = true;
                    MessageBox.Show("Country removed successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error deleting Country: " + e);
                    countryRemoved = false;
                }
                finally
                {
                    connection.Close();
                }

            return countryRemoved;
        }

        #endregion

        #region Relational / Returns

        public static bool CustomerExists(string cxName, int cxAddyId)
        {
            var cxIsDuplicate = false;
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            try
            {
                connection.Open();
                var checkDuplicate = connection.CreateCommand();
                checkDuplicate.CommandText =
                    "select EXISTS(select customerId FROM customer WHERE customerName = @cxName AND addressId = @cxAddyId LIMIT 1)";
                checkDuplicate.Parameters.AddWithValue("@cxName", cxName);
                checkDuplicate.Parameters.AddWithValue("@cxAddyId", cxAddyId);
                if (checkDuplicate.ExecuteScalar().ToString() != "0")
                {
                    cxIsDuplicate = true;
                    MessageBox.Show("Unable to save: existing customer with same name found at this address.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error checking for duplicate customers: " + e);
            }
            finally
            {
                connection.Close();
            }

            return cxIsDuplicate;
        }

        public static bool AddressExists(string Addy, int cityId)
        {
            var addyIsDuplicate = false;
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            try
            {
                connection.Open();
                var checkDuplicate = connection.CreateCommand();
                checkDuplicate.CommandText =
                    "select EXISTS(select addressId FROM address WHERE address = @addy AND cityId = @cityId LIMIT 1)";
                checkDuplicate.Parameters.AddWithValue("@addy", Addy);
                checkDuplicate.Parameters.AddWithValue("@cityId", cityId);
                if (checkDuplicate.ExecuteScalar().ToString() != "0")
                {
                    addyIsDuplicate = true;
                    MessageBox.Show("Unable to save: existing entry found for address.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error checking for duplicate addresses: " + e);
            }
            finally
            {
                connection.Close();
            }

            return addyIsDuplicate;
        }

        public static bool CityExists(string city, int countryId)
        {
            var cityIsDuplicate = false;
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            try
            {
                connection.Open();
                var checkDuplicate = connection.CreateCommand();
                checkDuplicate.CommandText =
                    "select EXISTS(select cityId FROM city WHERE city = @city AND countryId = @countryId LIMIT 1)";
                // Prevents overly harsh blocking - ie London, Ohio USA vs London, England
                checkDuplicate.Parameters.AddWithValue("@city", city);
                checkDuplicate.Parameters.AddWithValue("@countryId", countryId);
                if (checkDuplicate.ExecuteScalar().ToString() != "0")
                {
                    cityIsDuplicate = true;
                    MessageBox.Show("Unable to save: existing entry found for this city in that country.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error checking for duplicate cities: " + e);
            }
            finally
            {
                connection.Close();
            }

            return cityIsDuplicate;
        }

        public static bool CountryExists(string country)
        {
            var countryExists = false;
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            try
            {
                connection.Open();
                var checkDuplicate = connection.CreateCommand();
                checkDuplicate.CommandText =
                    "select EXISTS(select countryId FROM country WHERE country = @country  LIMIT 1)";
                checkDuplicate.Parameters.AddWithValue("@country", country);
                if (checkDuplicate.ExecuteScalar().ToString() != "0")
                {
                    countryExists = true;
                    MessageBox.Show("Unable to save: this country already exists in the DB.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error checking for duplicate countries: " + e);
            }
            finally
            {
                connection.Close();
            }

            return countryExists;
        }

        public static bool ForeignKeyInUse(string kindBeingChecked, int idBeingChecked)
        {
            // In the query parameters, it is more efficient/speedy to limit the results
            // since one or higher all represent potential violations of data integrity
            var keyInUse = false;
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            try
            {
                connection.Open();
                var checkCommand = connection.CreateCommand();

                switch (kindBeingChecked)
                {
                    case "address":
                        checkCommand.CommandText =
                            "SELECT count(*) from (select * from customer WHERE addressId = @addressId LIMIT 1);";
                        checkCommand.Parameters.AddWithValue("@addressId", idBeingChecked);
                        break;

                    case "city":
                        checkCommand.CommandText =
                            "SELECT count(*) from (select * from address WHERE cityId = @cityId LIMIT 1);";
                        checkCommand.Parameters.AddWithValue("@cityId", idBeingChecked);
                        break;

                    case "customer":
                        checkCommand.CommandText =
                            "SELECT count(*) from (select * from appointment WHERE customerId = @cxId LIMIT 1);";
                        checkCommand.Parameters.AddWithValue("@cxId", idBeingChecked);
                        break;

                    case "country":
                        checkCommand.CommandText =
                            "SELECT count(*) from (select * from city WHERE countryId = @countryId LIMIT 1);";
                        checkCommand.Parameters.AddWithValue("@countryId", idBeingChecked);
                        break;

                    // There is no functionality to add/edit/remove users in the system but this will support the same
                    // model being extended if/when appropriate.
                    case "user":
                        checkCommand.CommandText =
                            "SELECT count(*) from (select * from user WHERE userId = @userId LIMIT 1);";
                        checkCommand.Parameters.AddWithValue("@userId", idBeingChecked);
                        break;
                }

                if (checkCommand.ExecuteScalar().ToString() != "0")
                {
                    keyInUse = true;
                    Methods.IntegrityBlues();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem validating data: " + e);
            }
            finally
            {
                connection.Close();
            }

            return keyInUse;
        }

        #endregion

        #region Misc

        public static int WhoLoggedIn(string userName)
        {
            // Setup
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var userId = -1;

            try
            {
                connection.Open();
                var getUserId = connection.CreateCommand();
                getUserId.CommandText =
                    "SELECT userId FROM user WHERE username = @userName";
                getUserId.Parameters.AddWithValue("@userName", userName);

                var s_userId = getUserId.ExecuteScalar().ToString();
                if (s_userId != null) userId = int.Parse(s_userId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown while checking overlapping appointments: " + e);
            }
            finally
            {
                connection.Close();
            }

            return userId;
        }

        public static bool DoAppointmentsOverlap(DateTime start, DateTime end)
        {
            // Setup
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var appointmentsOverlap = false;

            try
            {
                connection.Open();
                var checkOverlap = connection.CreateCommand();
                checkOverlap.CommandText =
                    "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @end AND end >= @start)";
                checkOverlap.Parameters.AddWithValue("@start", start);
                checkOverlap.Parameters.AddWithValue("@end", end);

                if (checkOverlap.ExecuteScalar().ToString() == "1")
                {
                    appointmentsOverlap = true;
                    MessageBox.Show("Your appointment overlaps with an existing appointment.",
                        "Overlapping appointments detected");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown while checking overlapping appointments: " + e);
            }
            finally
            {
                connection.Close();
            }

            return appointmentsOverlap;
        }

        public static bool WillOrphanRows(string tableBeingChecked, string keyBeingChecked, string valueBeingChecked)
        {
            // Setup
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var exists = false;

            try
            {
                connection.Open();

                var sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText =
                    $"SELECT COUNT(*) as resultCount from {tableBeingChecked} WHERE {keyBeingChecked} = {valueBeingChecked}";

                var executeResult = sqlCommand.ExecuteScalar();
                var strResult = executeResult.ToString();
                var intResult = int.Parse(strResult);
                if (intResult > 0) // It might be faster in tables with hundreds of thousands or millions of rows
                    // to limit on the query so that as soon as one conflict is found the run stops.
                {
                    exists = true;
                    MessageBox.Show("This data is in use on another table and cannot be orphaned." +
                                    " No changes will be made.", "Data Integrity Violation");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown while evaluating data: " + e);
            }
            finally
            {
                connection.Close();
            }

            return exists;
        }


        public static bool DoesItExist(string tableBeingChecked, string keyBeingChecked, string valueBeingChecked)
        {
            // Setup
            var connection = new MySqlConnection(DbConnection.ConnectionString);
            var exists = false;

            try
            {
                connection.Open();

                var sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText =
                    $"SELECT COUNT(*) as resultCount from {tableBeingChecked} WHERE {keyBeingChecked} = {valueBeingChecked}";

                var executeResult = sqlCommand.ExecuteScalar();
                var strResult = executeResult.ToString();
                var intResult = int.Parse(strResult);
                if (intResult == 1) exists = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown while evaluating data: " + e);
            }
            finally
            {
                connection.Close();
            }

            return exists;
        }

        #endregion
    }
}