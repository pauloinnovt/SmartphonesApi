using SmartphonesApi.Domain.Smartphone;
using SmartphonesApi.Platform.Application.Smartphone.Commands;
using SmartphonesApi.Platform.Application.Smartphone.Dtos;

namespace SmartphonesApi.Platform.Application.Smartphone
{
    public class SmartphoneAppService(ISmartphoneRepository smartphoneRepo) : ISmartphoneAppService
    {
        private readonly ISmartphoneRepository smartphoneRepository = smartphoneRepo;

        public async Task<Guid> Add(AddSmartphoneCommand command, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(command, nameof(command));

            var smartphone = SmartphoneFactory.Create(command.Name, command.Brand, command.Storage);

            await smartphoneRepository.Save(smartphone, cancellationToken);

            return smartphone.Id;
        }

        public async Task<SmartphoneDto> Get(Guid id, CancellationToken cancellationToken = default)
        {
            if(id == Guid.Empty) throw new ArgumentNullException(nameof(id));

            var smartphone = await smartphoneRepository.GetBy(id, cancellationToken);

            if (smartphone == null) throw new ArgumentException("Smartphone not found");

            return smartphone.ToDto();
        }
    }
}
