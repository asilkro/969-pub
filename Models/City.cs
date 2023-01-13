using System;

namespace Silkroski_C969.Models
{
    public class City : BaseModel
    {
        public override string GetPrimaryKeyColumnName()
        {
            return "cityId";
        }

        public override int GetPrimaryKeyValue()
        {
            return CityId;
        }

        #region Properties / Fields

        [Generic_("cityId")] public int CityId { get; set; } // INT(10), Primary Key
        [Generic_("city")] public string CityName { get; set; } // VARCHAR(50)
        [Generic_("countryId")] public int CountryId { get; set; } // INT(10), Foreign Key (Country)
        [Generic_("createDate")] public DateTime? CreateDate { get; set; }
        [Generic_("createdBy")] public string CreatedBy { get; set; } // VARCHAR(40)
        [Generic_("lastUpdate")] public DateTime LastUpdate { get; set; }
        [Generic_("lastUpdateBy")] public string LastUpdateBy { get; set; } // VARCHAR(40) 

        #endregion

        #region Constructors

        public City()
        {
        }

        public City(int cityId, string city, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate,
            string lastUpdateBy)
        {
            CityId = cityId;
            CityName = city;
            CountryId = countryId;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}