using Innovt.Core.Attributes;
using SmartphonesApi.Platform.Application.Smartphone.Commands;

namespace SmartphonesApi.ViewModels
{
    [ModelExcludeFilter("Id")]
    public class DeleteSmartphoneByIdViewModel
    {
        [RequiredGuid]
        public Guid Id { get; set; }

        public DeleteSmartphoneByIdCommand ToCommand(Guid id)
        {
            var command = new DeleteSmartphoneByIdCommand()
            {
                Id = id
            };

            return command;
        }
    }
}
