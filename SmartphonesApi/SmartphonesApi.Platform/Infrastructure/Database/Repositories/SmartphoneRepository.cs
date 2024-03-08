using Innovt.Data.EFCore.Repositories;
using Innovt.Domain.Core.Repository;
using SmartphonesApi.Domain.Smartphone;

namespace SmartphonesApi.Platform.Infrastructure.Database.Repositories
{
    public class SmartphoneRepository(IExtendedUnitOfWork context) : RepositoryBase<Smartphone>(context) ,ISmartphoneRepository
    {


        //private readonly DataContext dataContext = context;

        //public async Task Save(Smartphone smartphone, CancellationToken cancellationToken = default)
        //{
        //    ArgumentNullException.ThrowIfNull(smartphone);

        //    await dataContext.Smartphones.AddAsync(smartphone, cancellationToken);
        //    dataContext.SaveChanges();
        //}

        //public async Task<Smartphone?> GetBy(Guid id, CancellationToken cancellationToken)
        //{
        //    if (id == Guid.Empty) throw new ArgumentNullException(nameof(id));

        //    var smartphone = await dataContext.Smartphones.FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

        //    return smartphone;
        //}

        //public async Task<List<Smartphone>?> GetAll(CancellationToken cancellationToken)
        //{
        //    var result = await dataContext.Smartphones.ToListAsync(cancellationToken);

        //    return result;
        //}

        //public async Task Delete(Smartphone smartphone, CancellationToken cancellationToken = default)
        //{
        //    ArgumentNullException.ThrowIfNull(smartphone);

        //    dataContext.Smartphones.Remove(smartphone);
        //    await dataContext.SaveChangesAsync(cancellationToken);
        //}

        //public async Task UpdateDatabase(CancellationToken cancellationToken)
        //{
        //    await dataContext.SaveChangesAsync(cancellationToken);
        //}

    }
}
