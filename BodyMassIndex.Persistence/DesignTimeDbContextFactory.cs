using BodyMassIndex.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BodyMassIndex.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BodyMassIndexDb>
    {
        public BodyMassIndexDb CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BodyMassIndexDb> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
