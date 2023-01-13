using System;

namespace Silkroski_C969.Models
{
    public class Address : BaseModel
    {
        public override string GetPrimaryKeyColumnName()
        {
            return "addressId";
        }

        public override int GetPrimaryKeyValue()
        {
            return AddressId;
        }

        #region Properties / Fields

        [Generic_("addressId")] public int AddressId { get; set; } // INT(10), Primary Key
        [Generic_("address")] public string Address1 { get; set; } // VARCHAR(50)
        [Generic_("address2")] public string Address2 { get; set; } // VARCHAR(50)
        [Generic_("cityId")] public int CityId { get; set; } // INT(10), Foreign Key (City)
        [Generic_("postalCode")] public string PostalCode { get; set; } // VARCHAR(10)
        [Generic_("phone")] public string Phone { get; set; } // VARCHAR(20)

        [Generic_("createDate")] public DateTime? CreateDate { get; set; }
        [Generic_("createdBy")] public string CreatedBy { get; set; } // VARCHAR(40)
        [Generic_("lastUpdate")] public DateTime LastUpdate { get; set; }
        [Generic_("lastUpdateBy")] public string LastUpdateBy { get; set; } // VARCHAR(40) 

        #endregion

        #region Constructors

        public Address()
        {
        }

        public Address(int addressId, string address1, string address2, int cityId, string postalCode, string phone,
            DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressId = addressId;
            Address1 = address1;
            Address2 = address2;
            CityId = cityId;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}