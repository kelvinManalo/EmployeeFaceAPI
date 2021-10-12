using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson;
using EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPerson;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmployeeFaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonGroupPersonController : ControllerBase
    {
        private readonly ILogger<PersonGroupPersonController> _logger;
        private readonly IPersonGroupPersonBusiness _personGroupPersonBusiness;

        public PersonGroupPersonController(ILogger<PersonGroupPersonController> logger, IPersonGroupPersonBusiness personGroupPersonBusiness)
        {
            _logger = logger;
            _personGroupPersonBusiness = personGroupPersonBusiness;
        }

        [HttpGet("Get/{groupId}")]
        public async Task<IActionResult> GetAll(string groupId)
        {
            return Ok(await _personGroupPersonBusiness.GetAll(groupId));
        }

        [HttpGet("GetById/{groupId}/{personId}")]
        public async Task<IActionResult> GetById(string groupId, string personId)
        {
            return Ok(await _personGroupPersonBusiness.GetById(groupId, personId));
        }

        [HttpPost("Create/{groupId}")]
        public async Task<IActionResult> Create(string groupId, [FromBody] PersonGroupPersonCreateInputDto input)
        {
            return Ok(await _personGroupPersonBusiness.Create(groupId, input));
        }

        [HttpPatch("Update/{groupId}/{personId}")]
        public async Task<IActionResult> Update(string groupId, string personId, [FromBody] PersonGroupPersonUpdateInputDto input)
        {
            return Ok(await _personGroupPersonBusiness.Update(groupId, personId, input));
        }

        [HttpDelete("Delete/{groupId}/{personId}")]
        public async Task<IActionResult> Delete(string groupId, string personId)
        {
            return Ok(await _personGroupPersonBusiness.Delete(groupId, personId));
        }

       


    }
}
