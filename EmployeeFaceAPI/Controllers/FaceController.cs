using EmployeeFace.BusinessLogic.DataTransferObjects.Face;
using EmployeeFace.BusinessLogic.LogicCollection.Face;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmployeeFaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaceController : ControllerBase
    {

        private readonly ILogger<FaceController> _logger;
        private readonly IFaceBusiness _faceBusiness;

        public FaceController(ILogger<FaceController> logger, IFaceBusiness faceBusiness)
        {
            _logger = logger;
            _faceBusiness = faceBusiness;
        }

        [HttpPost("Detect")]
        public async Task<IActionResult> Detect([FromForm] FaceDetectInputDto input)
        {
            return Ok(await _faceBusiness.Detect(input));
        }

        [HttpPost("Identify")]
        public async Task<IActionResult> Identify([FromBody] FaceIdentifyInputDto input)
        {
            return Ok(await _faceBusiness.Identify(input));
        }
    }
}
