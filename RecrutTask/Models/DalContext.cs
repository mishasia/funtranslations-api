using System.Data.Entity;

/// <summary>
/// 
/// </summary>

namespace RecrutTask.Models
{
    public class DalContext : DbContext
    {
        public DbSet<DataModelEntity> dataModelEntities { get; set; }
 
    }
}