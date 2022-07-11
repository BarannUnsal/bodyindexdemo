using BodyMassIndex.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BodyMassIndex.Application.Repositories
{
    public interface IDimensionsRepository
    {
        DbSet<Dimensions> Table { get; }
        public Task<bool> CreateAsync(Dimensions dimensions);
        Task<int> SaveAsync();
    }
}
