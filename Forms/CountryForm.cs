using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class CountryForm : Form
    {
        private readonly Country _countryInMemory = new Country();
        private readonly bool _update;

        #region Constructors

        public CountryForm()
        {
            InitializeComponent();
            PopulateCountryId();
            _update = false;
        }

        public CountryForm(Country countryBeingEdited)
        {
            InitializeComponent();
            _countryInMemory = countryBeingEdited;
            SaveButton.Text = "Update";
            countryIdTB.Text = countryBeingEdited.CountryId.ToString();
            countryNameTB.Text = countryBeingEdited.Country1;
            _update = true;
        }

        #endregion

        #region Methods

        private void PopulateCountryId()
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
                    "WHERE table_name = 'country' AND table_schema = DATABASE();";
                countryIdTB.Text = query.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error loading the CountryID: " + e);
                countryIdTB.Text = "Error!";
            }
            finally
            {
                connection.Close();
            }
        }

        private Country MakeCountryForSubmission()
        {
            var country = new Country
            {
                CountryId = Methods.ParseBox(countryIdTB.Text),
                Country1 = countryNameTB.Text,
                CreateDate = DateTime.Now.ToUniversalTime(),
                CreatedBy = "Schedule Software",
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return country;
        }

        private Country UpdateCountryForSubmission()
        {
            var country = new Country
            {
                CountryId = Methods.ParseBox(countryIdTB.Text),
                Country1 = countryNameTB.Text,
                CreateDate = _countryInMemory.CreateDate,
                CreatedBy = _countryInMemory.CreatedBy,
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return country;
        }

        #endregion

        #region Buttons / Events

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateBeforeSubmission())
            {
                if (_update)
                {
                    SqlSpecific.CountryUpdated(UpdateCountryForSubmission());
                    Methods.Cleanup(this);
                }
                else
                {
                    SqlSpecific.CountryInserted(MakeCountryForSubmission());
                    Methods.Cleanup(this);
                }
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            ValidateBeforeSubmission();
        }

        private bool ValidateBeforeSubmission()
        {
            var valid = true;
            TextBox[] textBoxes = {countryNameTB, countryIdTB};
            if (Methods.BoxesAreNotEmpty(textBoxes))
                if (string.IsNullOrWhiteSpace(countryNameTB.Text))
                {
                    countryNameTB.BackColor = Color.DarkRed;
                    Console.WriteLine("Empty Country names are not allowed.");
                    valid = false;
                }

            if (SqlSpecific.CountryExists(countryNameTB.Text)) valid = false;

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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Methods.Cancelled(this);
        }

        #endregion
    }
}