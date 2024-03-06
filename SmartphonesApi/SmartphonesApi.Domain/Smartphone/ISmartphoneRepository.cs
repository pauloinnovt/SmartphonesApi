
namespace SmartphonesApi.Domain.Smartphone
{
    public interface ISmartphoneRepository
    {
        Task<Smartphone> GetBy(Guid id, CancellationToken cancellationToken);
        Task Save(Smartphone smartphone, CancellationToken cancellationToken = default);
    }
}
