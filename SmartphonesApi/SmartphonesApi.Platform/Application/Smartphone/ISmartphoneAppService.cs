using SmartphonesApi.Platform.Application.Smartphone.Commands;
using SmartphonesApi.Platform.Application.Smartphone.Dtos;
using SmartphonesApi.Platform.Application.Smartphone.Filters;

namespace SmartphonesApi.Platform.Application.Smartphone
{
    public interface ISmartphoneAppService
    {
        Task<Guid> Add(AddSmartphoneCommand command, CancellationToken cancellationToken = default);
        Task<SmartphoneDto> Get(GetSmartphoneFilter command, CancellationToken cancellationToken = default); 
    }
}
