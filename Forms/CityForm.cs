using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class CityForm : Form
    {
        private readonly City _cityInMemory = new City();
        private readonly bool _update;

        #region Constructors

        public CityForm()
        {
            InitializeComponent();
            PopulateCityId();
            _update = false;
        }

        public CityForm(City cityBeingEdited)
        {
            InitializeComponent();
            _cityInMemory = cityBeingEdited;
            CityIdTB.Text = cityBeingEdited.CityId.ToString();
            CityNameTB.Text = cityBeingEdited.CityName;
            countryIdTB.Text = cityBeingEdited.CountryId.ToString();
            SaveButton.Text = "Update";
            _update = true;
        }

        #endregion

        #region Methods

        private void PopulateCityId()
        {
            var connection = new MySqlConnection(DbConnection.ConnectionString);

            try
            {
                connection.Open();
                var autoIncrement = connection.CreateCommand();
                autoIncrement.CommandText = "SET @@SESSION.information_schema_stats_expiry = 0;";
                autoIncrement.ExecuteNonQuery();

                var query = connection.CreateCommand();
                query.CommandText =
                    "SELECT AUTO_INCREMENT FROM information_schema.tables " +
                    "WHERE table_name = 'city' AND table_schema = DATABASE();";
                CityIdTB.Text = query.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error loading the CityId: " + e);
                CityIdTB.Text = "Error!";
            }
            finally
            {
                connection.Close();
            }
        }

        private City MakeCityForSubmission()
        {
            var city = new City
            {
                CityId = Methods.ParseBox(CityIdTB.Text),
                CityName = CityNameTB.Text,
                CountryId = Methods.ParseBox(countryIdTB.Text),
                CreateDate = DateTime.Now.ToUniversalTime(),
                CreatedBy = "Schedule Software",
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return city;
        }

        private City UpdateCityForSubmission()
        {
            var city = new City
            {
                CityId = Methods.ParseBox(CityIdTB.Text),
                CityName = CityNameTB.Text,
                CountryId = Methods.ParseBox(countryIdTB.Text),
                CreateDate = _cityInMemory.CreateDate,
                CreatedBy = _cityInMemory.CreatedBy,
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return city;
        }

        #endregion

        #region Buttons/Events

        private void CityCancelBtn_Click(object sender, EventArgs e)
        {
            Methods.Cancelled(this);
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            ValidateBeforeSubmission();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateBeforeSubmission())
            {
                if (_update)
                {
                    SqlSpecific.CityUpdated(UpdateCityForSubmission());
                    Methods.Cleanup(this);
                }
                else
                {
                    SqlSpecific.CityInserted(MakeCityForSubmission());
                    Methods.Cleanup(this);
                }
            }
        }

        private bool ValidateBeforeSubmission()
        {
            var valid = false;
            TextBox[] textBoxes = {CityIdTB, CityNameTB, countryIdTB};

            if (!SqlSpecific.CityExists(CityNameTB.Text, Methods.ParseBox(countryIdTB.Text))
                && int.TryParse(countryIdTB.Text, out _))
                valid = true;

            if (!SqlSpecific.DoesItExist("country", "countryId", countryIdTB.Text))
            {
                valid = false;
                countryIdTB.BackColor = Color.DarkRed;
                MessageBox.Show("There is no match for the Id you entered: " + countryIdTB.Text);
            }

            if (!Methods.BoxesAreNotEmpty(textBoxes)) valid = false;

            if (!int.TryParse(countryIdTB.Text, out _))
            {
                Console.WriteLine("CountryId must be an int.");
                countryIdTB.BackColor = Color.DarkRed;
                valid = false;
            }

            if (SqlSpecific.CityExists(CityNameTB.Text, Methods.ParseBox(countryIdTB.Text)))
            {
                Console.WriteLine("City already exists.");
                CityNameTB.BackColor = Color.DarkRed;
                valid = false;
            }

            switch (valid)
            {
                case true:
                    SaveButton.Enabled = true;
                    break;
                case false:
                    SaveButton.Enabled = false;
                    break;
            }

            return valid;
        }

        #endregion
    }
}