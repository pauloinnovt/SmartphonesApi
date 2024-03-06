using Microsoft.EntityFrameworkCore;
using SmartphonesApi.Domain.Smartphone;
using SmartphonesApi.Platform.Infrastructure.Database.Context;

namespace SmartphonesApi.Platform.Infrastructure.Database.Repositories
{
    public class SmartphoneRepository(DataContext context) : ISmartphoneRepository
    {
        private readonly DataContext dataContext = context;

        public async Task<Smartphone?> GetBy(Guid id, CancellationToken cancellationToken)
        {
            if (id == Guid.Empty) throw new ArgumentNullException(nameof(id));

            var smartphone = await dataContext.Smartphones.FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

            return smartphone;
        }

        public async Task Save(Domain.Smartphone.Smartphone smartphone, CancellationToken cancellationToken = default)
        {
            await dataContext.Smartphones.AddAsync(smartphone, cancellationToken);
            dataContext.SaveChanges();
        }
    }
}
