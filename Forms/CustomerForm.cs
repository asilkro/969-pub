using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly bool _update;
        private readonly Customer customerInMemory = new Customer();

        #region Constructors

        public CustomerForm()
        {
            InitializeComponent();
            PopulateCustomerId();
            _update = false;
        }

        public CustomerForm(Customer thisCustomer)
        {
            InitializeComponent();
            customerInMemory = thisCustomer;
            CxNameTB.Text = thisCustomer.CustomerName;
            SaveButton.Text = "Update";
            _update = true;
            CxAddressIdTB.Text = thisCustomer.AddressId.ToString();
            CxIdTB.Text = thisCustomer.CustomerId.ToString();
            CxNameTB.Text = thisCustomer.CustomerName;
        }

        #endregion

        #region Functions

        private Customer MakeCustomerForSubmission()
        {
            var cx = new Customer
            {
                CustomerId = Methods.ParseBox(CxIdTB.Text),
                CustomerName = CxNameTB.Text,
                AddressId = Methods.ParseBox(CxAddressIdTB.Text),
                Active = 1,
                CreateDate = DateTime.Now.ToUniversalTime(),
                CreatedBy = "Schedule Software",
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return cx;
        }

        private Customer UpdateCustomerForSubmission()
        {
            var cx = new Customer
            {
                CustomerId = Methods.ParseBox(CxIdTB.Text),
                CustomerName = CxNameTB.Text,
                AddressId = Methods.ParseBox(CxAddressIdTB.Text),
                Active = 1,
                CreateDate = customerInMemory.CreateDate,
                CreatedBy = customerInMemory.CreatedBy,
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = "Schedule Software"
            };
            return cx;
        }

        private void PopulateCustomerId()
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
                    "WHERE table_name = 'customer' AND table_schema = DATABASE();";
                CxIdTB.Text = query.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error loading the CustomerId: " + e);
                CxIdTB.Text = "Error!";
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Buttons/Events

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            ValidateBeforeSubmission();
        }

        private bool ValidateBeforeSubmission()
        {
            var valid = true;
            TextBox[] textBoxes = {CxIdTB, CxAddressIdTB, CxNameTB};
            {
                if (!Methods.BoxesAreNotEmpty(textBoxes)) valid = false;

                if (!int.TryParse(CxAddressIdTB.Text, out var _)) valid = false;

                if (SqlSpecific.CustomerExists(CxNameTB.Text, Methods.ParseBox(CxAddressIdTB.Text))) valid = false;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateBeforeSubmission())
            {
                if (_update)
                {
                    SqlSpecific.CustomerUpdated(UpdateCustomerForSubmission());
                    Methods.Cleanup(this);
                }
                else
                {
                    SqlSpecific.CustomerInserted(MakeCustomerForSubmission());
                    Methods.Cleanup(this);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Methods.Cancelled(this);
        }

        #endregion
    }
}