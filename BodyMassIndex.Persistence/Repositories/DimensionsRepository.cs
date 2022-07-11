using BodyMassIndex.Application.Repositories;
using BodyMassIndex.Domain.Entities;
using BodyMassIndex.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BodyMassIndex.Persistence.Repositories
{
    public class DimensionsRepository : IDimensionsRepository
    {
        readonly private BodyMassIndexDb _context;

        public DimensionsRepository(BodyMassIndexDb context)
        {
            _context = context;
        }

        public DbSet<Dimensions> Table => _context.Set<Dimensions>();

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        async Task<bool> IDimensionsRepository.CreateAsync(Dimensions dimensions)
        {
            EntityEntry<Dimensions> entityEntry = await Table.AddAsync(dimensions);
            return entityEntry.State == EntityState.Added;
        }
    }
}
