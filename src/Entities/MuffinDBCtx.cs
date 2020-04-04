using System.Data.Entity;

namespace Muffin.Entities
{
    class MuffinDbCtx : DbContext
    {
        public MuffinDbCtx()
            : base("muffinDb")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Event> Events { get; set; }
    }
}
