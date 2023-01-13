using System;

namespace Silkroski_C969.Models
{
    public class Generic_Attribute : Attribute
    {
        public Generic_Attribute(string _columnName)
        {
            ColumnName = _columnName;
        }

        public string ColumnName { get; set; }
    }
}