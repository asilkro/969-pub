using System;
using System.Windows.Forms;
using Silkroski_C969.Models;

namespace Silkroski_C969.Forms
{
    public partial class Alert : Form
    {
        #region Buttons / Events

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Constructors

        public Alert(Appointment appt)
        {
            InitializeComponent();
            cxTB.Text = appt.CustomerId.ToString();
            titleTB.Text = appt.Title;
            descTB.Text = appt.Description;
            locTB.Text = appt.Location;
            contactTB.Text = appt.Contact;
            typeTB.Text = appt.Type;
            startDTP.Value = appt.Start.ToLocalTime();
            endDTP.Value = appt.End.ToLocalTime();
        }

        public Alert(string cxId, string title, string desc, string location, string contact, string type,
            DateTime startDateTime, DateTime endDateTime)
        {
            InitializeComponent();
            cxTB.Text = cxId;
            titleTB.Text = title;
            descTB.Text = desc;
            locTB.Text = location;
            contactTB.Text = contact;
            typeTB.Text = type;
            startDTP.Value = startDateTime.ToLocalTime();
            endDTP.Value = endDateTime.ToLocalTime();
        }

        #endregion
    }
}