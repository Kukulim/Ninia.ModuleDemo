using NiniaDomain.Classes;
using System.Data.Entity;

namespace NinjaDomain.DataModel
{
    public class NinjaContext: System.Data.Entity.DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinijaEquipnent> NinijaEquipnents { get; set; }
    }
}
