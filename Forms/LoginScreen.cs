using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class LoginScreen : Form
    {
        #region Constructors

        public LoginScreen()
        {
            InitializeComponent();
            SetLanguage();
        }

        #endregion

        public string Language { get; private set; }

        public MySqlConnection Connection { get; }

        #region Methods

        public bool IsValidLogin()
        {
            var isValid = true;
            var userName = UserField.Text;
            var password = PasswordField.Text;

            var conn = new MySqlConnection(DbConnection.ConnectionString);

            // Don't even attempt to login with empty fields.
            if (FieldsAreEmpty())
            {
                isValid = false;
                return isValid;
            }

            if (conn.State != ConnectionState.Open) conn.Open();

            var checkUser = conn.CreateCommand();
            checkUser.CommandText = "SELECT EXISTS(SELECT userName FROM user WHERE userName = @username)";
            checkUser.Parameters.AddWithValue("@userName", userName);
            var resultUserName = checkUser.ExecuteScalar().ToString(); // Returns '1' if it exists

            var checkPassword = conn.CreateCommand();
            checkPassword.CommandText =
                "SELECT EXISTS(SELECT password FROM user WHERE BINARY password = @password AND userName = @username)";
            checkPassword.Parameters.AddWithValue("@password", password);
            checkPassword.Parameters.AddWithValue("@userName", userName);
            var resultPassword = checkPassword.ExecuteScalar().ToString(); // Returns '1'

            // Success and error messages depend on which language the system is using
            if (resultUserName == "1" && resultPassword == "1")
            {
                switch (Language)
                {
                    case "US-EN":
                        MessageBox.Show("Login successful", "Success");
                        isValid = true;
                        break;
                    case "DE-DE":
                        MessageBox.Show("Anmeldung erfolgreich", "Erfolg");
                        isValid = true;
                        break;
                    default:
                        MessageBox.Show("Login successful", "Success");
                        isValid = true;
                        break;
                }

                Log.LogMessage("User: " + userName + " logged in ");
                conn.Dispose();
                return isValid;
            }

            switch (Language)
            {
                case "US-EN":
                    MessageBox.Show("Login failed", "Failure");
                    isValid = false;
                    break;
                case "DE-DE":
                    MessageBox.Show("Fehler bei der Anmeldung", "Versagen");
                    isValid = false;
                    break;
                default:
                    MessageBox.Show("Login failed", "Failure");
                    isValid = false;
                    break;
            }

            Log.LogMessage("User: " + userName + " failed to login ");
            conn.Dispose();
            return isValid;
        }

        private bool FieldsAreEmpty()
        {
            var isEmpty = false;

            if (!UserField.Text.Any())
                switch (Language)
                {
                    case "DE-DE":
                        MessageBox.Show("Bitte geben Sie einen Benutzernamen ein",
                            "Benutzername ist nicht vorhanden");
                        isEmpty = true;
                        break;
                    case "EN-US":
                        MessageBox.Show("Please enter a username",
                            "Username is not present");
                        isEmpty = true;
                        break;
                }

            if (!PasswordField.Text.Any())
                switch (Language)
                {
                    case "DE-DE":
                        MessageBox.Show("Bitte Passwort eingeben",
                            "Leeres Passwortfeld");
                        isEmpty = true;
                        break;
                    case "EN-US":
                        MessageBox.Show("Please enter a password",
                            "Empty password field");
                        isEmpty = true;
                        break;
                }

            return isEmpty;
        }

        #endregion

        #region Languages / Sprache

        private void SetLanguage()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)
            {
                case "United States":
                    SetToEnglish();
                    Language = "US-EN";
                    break;

                case "Germany":
                    SetToGerman();
                    Language = "DE-DE";
                    break;

                default:
                    SetToEnglish();
                    break;
            }
        }

        public void SetToGerman()
        {
            UserIDLabel.Text = "Benutzer-ID";
            PasswordLabel.Text = "Passwort";
            LoginBtn.Text = "Anmelden";
            ClearBtn.Text = "Leeren";
            ExitBtn.Text = "Schließen";
        }

        public void SetToEnglish()
        {
            UserIDLabel.Text = "UserID";
            PasswordLabel.Text = "Password";
            LoginBtn.Text = "Login";
            ClearBtn.Text = "Clear";
            ExitBtn.Text = "Exit";
        }

        #endregion

        #region Events

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsValidLogin())
            {
                OnLoginButtonClick();
                var userId = SqlSpecific.WhoLoggedIn(UserField.Text);
                var ms = new MainScreen(userId);
                ms.StartPosition = FormStartPosition.CenterParent;
                ms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check your login credentials and try again", "Invalid Login");
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            if (Connection != null)
                if (Connection.State != ConnectionState.Closed)
                    Connection.Dispose();
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserField.Text = null;
            PasswordField.Text = null;
        }

        private void OnLoginButtonClick()
        {
            // Error messages depend on which language the system is using
            if (Language == "DE-DE") // Germany - German
                try
                {
                    Console.WriteLine(UserField.Text + " angemeldet ");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ausnahme während der Anmeldung ausgelöst: " + e);
                }

            if (Language == "US-EN") // United States - English
                try
                {
                    Console.WriteLine(UserField.Text + " signed in ");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception thrown during login: " + e);
                }

            else // Reminder to check configuration
                MessageBox.Show("Your current system configuration is not supported by this application.",
                    "Unsupported System Configuration");
        }

        #endregion
    }
}