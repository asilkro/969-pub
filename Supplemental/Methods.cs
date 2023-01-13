using System;
using System.Drawing;
using System.Windows.Forms;

namespace Silkroski_C969.Supplemental
{
    public class Methods
    {
        #region Lambda Expressions

        // One line methods are excellent candidates for Lambdas
        public static void IntegrityBlues()
        {
            MessageBox.Show("This operation is not permitted due to data integrity constraints.",
                "Data Integrity Constraint Violation");
        }

        #endregion

        #region Form Specifc

        public static void Cancelled(Form formBeingCancelled)
        {
            MessageBox.Show("Cancelled, no changes made.", "CANCELLED");
            formBeingCancelled.Close();
            formBeingCancelled.Dispose();
        }

        public static void Cleanup(Form formBeingCleanedUp)
        {
            formBeingCleanedUp.Close();
            formBeingCleanedUp.Dispose();
        }

        public static int ParseBox(string boxContent)
        {
            int.TryParse(boxContent, out var x);
            return x;
        }

        #endregion

        #region Datetime & Validation

        public static DateTime CombineDateTime(DateTime date, DateTime clock)
        {
            var dateTimeBeingReturned =
                new DateTime(date.Year, date.Month, date.Day,
                    clock.Hour, clock.Minute, 0);
            return dateTimeBeingReturned;
        }

        public static double DateTimeDurationInMinutes(DateTime start, DateTime end)
        {
            var timeSpan = end - start;
            var duration = timeSpan.TotalMinutes;

            return duration;
        }

        public static bool NoDurationErrors(int dtDuration)
        {
            var durationValid = true;
            if (dtDuration < 15)
            {
                MessageBox.Show("Appointments under 15 minutes are not permitted.",
                    "Appointment Minimum Duration Error");
                durationValid = false;
            }

            if (dtDuration > 60)
            {
                MessageBox.Show("Appointments over 60 minutes are not permitted.",
                    "Appointment Maximum Duration Error");
                durationValid = false;
            }

            return durationValid;
        }

        public static TimeSpan GetDateTimeOffset(DateTime dateTime, TimeZoneInfo localTimeZone)
        {
            var offset = localTimeZone.GetUtcOffset(dateTime);
            return offset;
        }

        public static DateTime ConvertedDateTime(DateTime dateTime, TimeSpan offset)
        {
            var dt = dateTime + offset;
            return dt;
        }

        public static bool BoxesAreNotEmpty(TextBox[] textboxes)
        {
            var boxesAreGood = false;
            //Loop to check if each textBox is empty
            foreach (var txt in textboxes)
            {
                if (string.IsNullOrWhiteSpace(txt.Text) || string.IsNullOrEmpty(txt.Text))
                {
                    txt.BackColor = Color.DarkRed;
                    MessageBox.Show("You do not seem to have anything in a required field.", "Empty field error.");
                    boxesAreGood = false;
                    break;
                }

                txt.BackColor = default;
                boxesAreGood = true;
            }

            return boxesAreGood;
        }

        #endregion
    }
}