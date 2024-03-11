using Microsoft.AspNetCore.Mvc;
using SmartphonesApi.Platform.Application.Smartphone;
using SmartphonesApi.Platform.Application.Smartphone.Commands;
using SmartphonesApi.ViewModels;

namespace SmartphonesApi.Controllers
{
    [Controller]
    [Route("")]
    public class SmartphonesController(ISmartphoneAppService appService) : ControllerBase
    {
        private readonly ISmartphoneAppService smartphoneAppService = appService;

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddSmartphoneCommand command, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(command, nameof(command));

            var result = await smartphoneAppService.Add(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(GetSmartphoneByIdViewModel viewModel, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(viewModel, nameof(viewModel));

            var result = await smartphoneAppService.Get(viewModel.ToFilter(), cancellationToken);

            if (result is null)
                return NoContent();

            return Ok(result);
        }

        //[HttpPut]
        //public async Task<IActionResult> Update([FromBody] UpdateSmartphoneCommand command, CancellationToken cancellationToken = default)
        //{
        //    ArgumentNullException.ThrowIfNull(command, nameof(command));

        //    var result = await smartphoneAppService.Update(command, cancellationToken);

        //    return Ok(result);
        //}



        //[HttpGet("/All")]
        //public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        //{
        //    var result = await smartphoneAppService.GetAll(cancellationToken);

        //    return Ok(result);
        //}

        //[HttpDelete("{id:guid}")]
        //public async Task<IActionResult> Delete([FromRoute] Guid id, DeleteSmartphoneByIdViewModel viewModel, CancellationToken cancellationToken = default)
        //{
        //    ArgumentNullException.ThrowIfNull(viewModel, nameof(viewModel));

        //    await smartphoneAppService.Delete(viewModel.ToCommand(id), cancellationToken);

        //    return Ok();
        //}
    }
}
