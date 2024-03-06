using Microsoft.AspNetCore.Mvc;
using SmartphonesApi.Platform.Application.Smartphone;
using SmartphonesApi.Platform.Application.Smartphone.Commands;

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
            var result = await smartphoneAppService.Add(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var result = await smartphoneAppService.Get(id, cancellationToken);

            return Ok(result);
        }
    }
}
