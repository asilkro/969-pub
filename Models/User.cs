using System;

namespace Silkroski_C969.Models
{
    public class User // user == consultant per FAQ
    {
        #region Properties / Fields

        // All these are from the Database ERD
        public int UserId { get; set; } // INT, Primary Key
        public string UserName { get; set; } // VARCHAR(50)
        public string Password { get; protected set; } // VARCHAR(50)
        private byte Active { get; set; } // TINYINT in MySQL is just a byte

        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion
    }
}