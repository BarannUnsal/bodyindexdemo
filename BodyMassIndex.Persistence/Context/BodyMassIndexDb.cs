using BodyMassIndex.Domain.Entities;
using BodyMassIndex.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BodyMassIndex.Persistence.Context
{
    public class BodyMassIndexDb : DbContext
    {
        public BodyMassIndexDb(DbContextOptions options) : base(options)
        {}
        public DbSet<Dimensions> Dimensions{ get; set; }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach(var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
