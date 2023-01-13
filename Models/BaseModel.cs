namespace Silkroski_C969.Models
{
    public abstract class BaseModel
    {
        public abstract string GetPrimaryKeyColumnName();
        public abstract int GetPrimaryKeyValue();
    }
}