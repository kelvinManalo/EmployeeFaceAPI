using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPersonFace;
using EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPersonFace;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmployeeFaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllHeaders")]
    public class PersonGroupPersonFaceController : ControllerBase
    {
        private readonly ILogger<PersonGroupPersonFaceController> _logger;
        private readonly IPersonGroupPersonFaceBusiness _personGroupPersonFaceBusiness;

        public PersonGroupPersonFaceController(ILogger<PersonGroupPersonFaceController> logger, IPersonGroupPersonFaceBusiness personGroupPersonFaceBusiness)
        {
            _logger = logger;
            _personGroupPersonFaceBusiness = personGroupPersonFaceBusiness;
        }

        [HttpPost("Create/{groupId}/persons/{personId}")]
        public async Task<IActionResult> Create(string groupId, string personId, [FromForm] PersonGroupPersonFaceCreateInputDto input)
        {
            return Ok(await _personGroupPersonFaceBusiness.Create(groupId, personId, input));
        }

        [HttpPatch("Update/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}")]
        public async Task<IActionResult> Update(string groupId, string personId, string persistedFaceId, [FromBody] PersonGroupPersonFaceUpdateInputDto input)
        {
            return Ok(await _personGroupPersonFaceBusiness.Update(groupId, personId, persistedFaceId, input));
        }

        [HttpDelete("Delete/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}")]
        public async Task<IActionResult> Delete(string groupId, string personId, string persistedFaceId)
        {
            return Ok(await _personGroupPersonFaceBusiness.Delete(groupId, personId, persistedFaceId));
        }

        [HttpGet("GetById/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}")]
        public async Task<IActionResult> GetById(string groupId, string personId, string persistedFaceId)
        {
            return Ok(await _personGroupPersonFaceBusiness.GetById(groupId, personId, persistedFaceId));
        }
    }
}
