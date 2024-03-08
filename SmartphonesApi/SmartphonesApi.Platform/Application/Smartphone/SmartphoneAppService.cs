using Innovt.Core.Validation;
using SmartphonesApi.Domain.Smartphone;
using SmartphonesApi.Domain.Smartphone.Exceptions;
using SmartphonesApi.Domain.Smartphone.Specifications;
using SmartphonesApi.Platform.Application.Extensions;
using SmartphonesApi.Platform.Application.Smartphone.Commands;
using SmartphonesApi.Platform.Application.Smartphone.Dtos;
using SmartphonesApi.Platform.Application.Smartphone.Filters;

namespace SmartphonesApi.Platform.Application.Smartphone
{
    public class SmartphoneAppService(ISmartphoneRepository smartphoneRepo) : ISmartphoneAppService
    {
        private readonly ISmartphoneRepository smartphoneRepository = smartphoneRepo ?? throw new ArgumentNullException(nameof(smartphoneRepo));

        public async Task<Guid> Add(AddSmartphoneCommand command, CancellationToken cancellationToken = default)
        {
            command.EnsureIsValid();

            var smartphone = SmartphoneFactory.Create(command.Name, command.Brand, command.Storage);

            await smartphoneRepository.AddAsync(smartphone);

            return smartphone.Id;
        }

        public Task Delete(DeleteSmartphoneByIdCommand command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        //Get é filter, alterar
        public async Task<SmartphoneDto> Get(GetSmartphoneFilter filter, CancellationToken cancellationToken = default)
        {
            if (filter.Id == Guid.Empty) throw new ArgumentNullException(nameof(filter));

            //TODO Criar specifications
            var smartphone = await smartphoneRepository.GetFirstOrDefaultAsync(new SmartphoneByIdSpecification(filter.Id), cancellationToken: cancellationToken);

            return smartphone is null ? throw new SmartphoneNotFoundException(filter.Id) : smartphone.ToDto();
        }
    }
}
