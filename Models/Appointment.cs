using System;

namespace Silkroski_C969.Models
{
    public sealed class Appointment : BaseModel
    {
        public override string GetPrimaryKeyColumnName()
        {
            return "appointmentId";
        }

        public override int GetPrimaryKeyValue()
        {
            return AppointmentId;
        }

        #region Properties / Fields

        [Generic_("appointmentId")] public int AppointmentId { get; set; } // INT(10), Primary Key
        [Generic_("customerId")] public int CustomerId { get; set; } // INT(10), Foreign Key (Customer)
        [Generic_("userId")] public int UserId { get; set; } // INT from User.cs, Foreign Key (User)
        [Generic_("title")] public string Title { get; set; } // VARCHAR(255)
        [Generic_("description")] public string Description { get; set; } // TEXT
        [Generic_("location")] public string Location { get; set; } // TEXT
        [Generic_("contact")] public string Contact { get; set; } // TEXT
        [Generic_("type")] public string Type { get; set; } // TEXT
        [Generic_("url")] public string Url { get; set; } // VARCHAR(255)
        [Generic_("start")] public DateTime Start { get; set; }
        [Generic_("end")] public DateTime End { get; set; }
        [Generic_("createDate")] public DateTime? CreateDate { get; set; }
        [Generic_("createdBy")] public string CreatedBy { get; set; } // VARCHAR(40)
        [Generic_("lastUpdate")] public DateTime LastUpdate { get; set; }
        [Generic_("lastUpdateBy")] public string LastUpdateBy { get; set; } // VARCHAR(40) 

        #endregion

        #region Constructors

        public Appointment()
        {
        }

        public Appointment(int appointmentId, int customerId, int userId, string title, string description,
            string location, string contact, string type, string url, DateTime createDate, string createdBy,
            DateTime lastUpdate, string lastUpdateBy)
        {
            AppointmentId = appointmentId;
            CustomerId = customerId;
            UserId = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}