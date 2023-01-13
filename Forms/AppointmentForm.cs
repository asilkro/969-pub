using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.Supplemental;

namespace Silkroski_C969.Forms
{
    public partial class AppointmentForm : Form
    {
        private readonly Appointment _apptInMemory = new Appointment();
        private readonly bool _update;

        #region Constructors

        public AppointmentForm(MainScreen mainScreen)
        {
            InitializeComponent();
            WhatsMyTz();
            PopulateAppointmentId();
            _update = false;
        }

        public AppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            WhatsMyTz();
            _apptInMemory = appointment;
            _update = true;
            SaveButton.Text = "Update";
            AppointmentIdTB.Text = appointment.AppointmentId.ToString();
            userIdTB.Text = appointment.UserId.ToString();
            CustomerId_TB.Text = appointment.CustomerId.ToString();
            AptTitleTB.Text = appointment.Title;
            AptDetailsTB.Text = appointment.Description;
            startDateTimeCal.Value = appointment.Start.Date.ToLocalTime();
            startDateTimeClock.Value = appointment.Start.ToLocalTime();
            if (appointment.End.Date <= endDateTimeClock.MinDate)
            {
                MessageBox.Show(
                    "This appointment ends too far in the past. You will be unable to save until this is corrected.",
                    "Appointment outside of expected bounds.");
                endDateTimeClock.Value = DateTime.MinValue;
            }

            if (appointment.End.Date >= endDateTimeClock.MaxDate)
            {
                MessageBox.Show(
                    "This appointment ends too far in the future. You will be unable to save until this is corrected.",
                    "Appointment outside of expected bounds.");
                endDateTimeClock.Value = DateTime.MaxValue;
            }
            else
            {
                appointment.End = GetEnd();
            }
        }

        #endregion

        #region Functions

        private bool TextBoxesAreValid()
            // Checks if boxes are empty and if the customerId/userIds are valid
            // to avoid submitting bad data
        {
            var valid = false;

            TextBox[] textboxes =
            {
                AppointmentIdTB, CustomerId_TB, AptTitleTB, AptDetailsTB, userIdTB,
                AptLocTB, AptUrlTB, AptContactTB
            };

            if (Methods.BoxesAreNotEmpty(textboxes))
                if (SqlSpecific.DoesItExist("user", "userId", userIdTB.Text))
                    if (SqlSpecific.DoesItExist("customer", "customerId", CustomerId_TB.Text))
                        valid = true;

            return valid;
        }

        private bool AppointmentDetailsAreValid()
        {
            var isValid = true;

            var start = GetStart();
            var end = GetEnd();
            var duration = Methods.DateTimeDurationInMinutes(start, end);
            bool[] validationMethods =
            {
                TimeIsValid(start.Hour, end.Hour, start.Minute, end.Minute),
                Methods.NoDurationErrors((int) duration), TextBoxesAreValid()
            }; // Can expand with other validation

            foreach (var method in validationMethods)
                if (!method)
                    isValid = false;

            return isValid;
        }

        private DateTime GetStart()
        {
            var start = Methods.CombineDateTime(startDateTimeCal.Value.Date, startDateTimeClock.Value);
            return start;
        }

        private DateTime GetEnd()
        {
            var end = Methods.CombineDateTime(startDateTimeCal.Value.Date, endDateTimeClock.Value);
            return end;
        }

        private TimeSpan GetTimeSpan()
        {
            var timeMod = Methods.GetDateTimeOffset(GetStart(), TimeZoneInfo.Local);
            return timeMod;
        }

        private Appointment MakeApptForSubmission()
        {
            var appt = new Appointment
            {
                AppointmentId = Methods.ParseBox(AppointmentIdTB.Text),
                CustomerId = Methods.ParseBox(CustomerId_TB.Text),
                UserId = Methods.ParseBox(userIdTB.Text),
                Title = AptTitleTB.Text,
                Start = GetStart(),
                End = GetEnd(),
                Description = AptDetailsTB.Text,
                Location = AptLocTB.Text,
                Contact = AptContactTB.Text,
                Url = AptUrlTB.Text,
                Type = AptTypeTB.Text,
                CreateDate = DateTime.Now,
                CreatedBy = "Schedule Software",
                LastUpdate = DateTime.Now,
                LastUpdateBy = "Schedule Software"
            };
            return appt;
        }

        private Appointment UpdateApptForSubmission()
        {
            var appt = new Appointment
            {
                AppointmentId = Methods.ParseBox(AppointmentIdTB.Text),
                CustomerId = Methods.ParseBox(CustomerId_TB.Text),
                UserId = Methods.ParseBox(userIdTB.Text),
                Title = AptTitleTB.Text,
                Start = GetStart(),
                End = GetEnd(),
                Description = AptDetailsTB.Text,
                Location = _apptInMemory.Location,
                Contact = _apptInMemory.Contact,
                Url = _apptInMemory.Url,
                Type = AptTypeTB.Text,
                CreateDate = _apptInMemory.CreateDate,
                CreatedBy = _apptInMemory.CreatedBy,
                LastUpdate = DateTime.Now,
                LastUpdateBy = "Schedule Software"
            };
            return appt;
        }

        private void PopulateAppointmentId()
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
                    "WHERE table_name = 'appointment' AND table_schema = DATABASE();";
                AppointmentIdTB.Text = query.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error loading the ApptId: " + e);
                AppointmentIdTB.Text = "Error!";
            }
            finally
            {
                connection.Close();
            }
        }

        private bool TimeIsValid(int startHour, int endHour, int startMinute, int endMinute)
        {
            var valid = true;
            var hoursToBeChecked = new List<int>
            {
                startHour,
                endHour
            };

            foreach (var hour in hoursToBeChecked)
                // Outside of range
                if (hour < 09 || hour > 21)
                    valid = false;

            // Appts can't begin at closing
            if (startHour >= 21)
            {
                valid = false;
                MessageBox.Show("Business Hours are 9am to 9pm", "Business Hours Violation");
                return valid;
            }

            // Appt can't end after closing
            if (endHour >= 21 && endMinute != 0)
            {
                valid = false;
                MessageBox.Show("Business Hours are 9am to 9pm", "Business Hours Violation");
                return valid;
            }

            return valid;
        }

        private void WhatsMyTz()
        {
            tzLbl.Text += TimeZoneInfo.Local.ToString();
        }

        #endregion

        #region Button Clicks / Events

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            switch (AppointmentDetailsAreValid())
            {
                case true:
                    SaveButton.Enabled = true;
                    break;
                case false:
                    SaveButton.Enabled = false;
                    break;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!AppointmentDetailsAreValid())
                MessageBox.Show(
                    "Check your data - Business Hours are 9am to 9pm, and all fields must be filled with valid Customer and User Ids.",
                    "Validation Error");

            if (_update && AppointmentDetailsAreValid())
                if (SqlSpecific.AppointmentUpdated(UpdateApptForSubmission()))
                    Methods.Cleanup(this);

            if (!_update && AppointmentDetailsAreValid())
                if (SqlSpecific.AppointmentInserted(MakeApptForSubmission()))
                    Methods.Cleanup(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Methods.Cancelled(this);
        }

        #endregion
    }
}