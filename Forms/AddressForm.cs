using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class AddressForm : Form
    {
        private readonly Address _addyInMemory = new Address();
        private readonly bool _update;

        #region Constructors

        public AddressForm()
        {
            _update = false;
            InitializeComponent();
            PopulateAddressId();
        }

        public AddressForm(Address address)
        {
            _addyInMemory = address;
            _update = true;
            InitializeComponent();
            addressIdTB.Text = address.AddressId.ToString();
            address1Tb.Text = address.Address1;
            address2Tb.Text = address.Address2;
            postalTb.Text = address.PostalCode;
            phoneTb.Text = address.Phone;
            cityIdTb.Text = address.CityId.ToString();
        }

        #endregion

        #region Methods

        private void PopulateAddressId()
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
                addressIdTB.Text = query.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error loading the AddressId: " + e);
                addressIdTB.Text = "Error!";
            }
            finally
            {
                connection.Close();
            }
        }

        private Address MakeAddressForSubmission()
        {
            var addy = new Address
            {
                AddressId = Methods.ParseBox(addressIdTB.Text),
                Address1 = address1Tb.Text,
                Address2 = address2Tb.Text,
                CityId = Methods.ParseBox(cityIdTb.Text),
                PostalCode = postalTb.Text,
                Phone = phoneTb.Text,
                CreateDate = DateTime.Now.ToUniversalTime(),
                CreatedBy = "Schedule Software",
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return addy;
        }

        private Address UpdateAddressForSubmission()
        {
            var addy = new Address
            {
                AddressId = Methods.ParseBox(addressIdTB.Text),
                Address1 = address1Tb.Text,
                Address2 = address2Tb.Text,
                CityId = Methods.ParseBox(cityIdTb.Text),
                PostalCode = postalTb.Text,
                Phone = phoneTb.Text,
                CreateDate = _addyInMemory.CreateDate,
                CreatedBy = _addyInMemory.CreatedBy,
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return addy;
        }

        #endregion

        #region Buttons/Events

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
                    if (SqlSpecific.AddressUpdated(UpdateAddressForSubmission()))
                    {
                        Console.WriteLine("Successfully saved.");
                        Methods.Cleanup(this);
                    }
                    else
                    {
                        Console.WriteLine("Error saving.");
                        Methods.Cleanup(this);
                    }
                }
                else
                {
                    if (SqlSpecific.AddressInserted(MakeAddressForSubmission()))
                    {
                        Console.WriteLine("Successfully saved.");
                        Methods.Cleanup(this);
                    }
                    else
                    {
                        Console.WriteLine("Error saving.");
                        Methods.Cleanup(this);
                    }
                }
            }
        }

        private bool ValidateBeforeSubmission()
        {
            var valid = true;
            TextBox[] textBoxes = {address1Tb, address2Tb, postalTb, phoneTb, cityIdTb};


            if (Methods.BoxesAreNotEmpty(textBoxes)) valid = true;

            if (SqlSpecific.AddressExists(address1Tb.Text, Methods.ParseBox(cityIdTb.Text)))
                if (SqlSpecific.AddressExists(phoneTb.Text, Methods.ParseBox(cityIdTb.Text)))
                    if (SqlSpecific.AddressExists(postalTb.Text, Methods.ParseBox(cityIdTb.Text)))
                        valid = false;

            if (SqlSpecific.DoesItExist("city", "cityId", cityIdTb.Text))
            {
                valid = true;
            }
            else
            {
                cityIdTb.BackColor = Color.DarkRed;
                MessageBox.Show("There is no city with the Id you entered: " + cityIdTb.Text);
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Methods.Cancelled(this);
        }

        #endregion
    }
}