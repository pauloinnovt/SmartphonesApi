using SmartphonesApi.Domain.Smartphone;
using SmartphonesApi.Platform.Application.Smartphone.Commands;
using SmartphonesApi.Platform.Application.Smartphone.Dtos;

namespace SmartphonesApi.Platform.Application.Smartphone
{
    public interface ISmartphoneAppService
    {
        Task<Guid> Add(AddSmartphoneCommand command, CancellationToken cancellationToken = default);
        Task<SmartphoneDto> Get(Guid id, CancellationToken cancellationToken = default);
    }
}
