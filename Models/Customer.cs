using System;

namespace Silkroski_C969.Models
{
    public class Customer : BaseModel
    {
        public override string GetPrimaryKeyColumnName()
        {
            return "customerId";
        }

        public override int GetPrimaryKeyValue()
        {
            return CustomerId;
        }

        #region Properties / Fields

        // All these are from the Database ERD
        [Generic_("customerId")] public int CustomerId { get; set; } // INT(10), Primary Key
        [Generic_("customerName")] public string CustomerName { get; set; } // VARCHAR(45)
        [Generic_("addressId")] public int AddressId { get; set; } // INT(10), Foreign Key (Address)

        [Generic_("active")]
        public int
            Active { get; set; } // TINYINT in MySQL is just a byte (Also in User class) - using an INT since it's

        // not editable by the user of this application.
        [Generic_("createDate")] public DateTime? CreateDate { get; set; }
        [Generic_("createdBy")] public string CreatedBy { get; set; } // VARCHAR(40)
        [Generic_("lastUpdate")] public DateTime LastUpdate { get; set; }
        [Generic_("lastUpdateBy")] public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion

        #region Constructors

        public Customer()
        {
        }

        public Customer(int customerId, string customerName, int addressId, int active, DateTime createDate,
            string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressId = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}