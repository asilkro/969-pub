using System;

namespace Silkroski_C969.Models
{
    public class Country : BaseModel
    {
        public override string GetPrimaryKeyColumnName()
        {
            return "countryId";
        }

        public override int GetPrimaryKeyValue()
        {
            return CountryId;
        }

        #region Properties / Fields

        [Generic_("countryId")] public int CountryId { get; set; } // INT(10), Primary Key
        [Generic_("country")] public string Country1 { get; set; } // VARCHAR(50)
        [Generic_("createDate")] public DateTime? CreateDate { get; set; }
        [Generic_("createdBy")] public string CreatedBy { get; set; } // VARCHAR(40)
        [Generic_("lastUpdate")] public DateTime LastUpdate { get; set; }
        [Generic_("lastUpdateBy")] public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion

        #region Constructors

        public Country()
        {
        }

        public Country(int countryId, string country, DateTime? createDate, string createdBy, DateTime lastUpdate,
            string lastUpdateBy)
        {
            CountryId = countryId;
            Country1 = country;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public Country(int countryId, string country, DateTime lastUpdate, string lastUpdateBy)
            : this(countryId, country, null, null, lastUpdate, lastUpdateBy)
        {
        }

        #endregion
    }
}