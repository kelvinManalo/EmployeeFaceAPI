using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroup;
using EmployeeFace.BusinessLogic.LogicCollection.PersonGroup;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmployeeFaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonGroupController : ControllerBase
    {
        private readonly ILogger<PersonGroupController> _logger;
        private readonly IPersonGroupBusiness _personGroupBusiness;


        public PersonGroupController(ILogger<PersonGroupController> logger, IPersonGroupBusiness personGroupBusiness)
        {
            _logger = logger;
            _personGroupBusiness = personGroupBusiness;
        }

        //get all employees

        [HttpGet("Get")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _personGroupBusiness.GetAll());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] string personGroupId)
        {
            return Ok(await _personGroupBusiness.GetById(personGroupId));
        }

        [HttpPut("Create")]
        public async Task<IActionResult> Create([FromBody] PersonGroupServiceCreateInputDto input)
        {
            return Ok(await _personGroupBusiness.Create(input));
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update([FromBody] PersonGroupServiceUpdateInputDto input)
        {
            return Ok(await _personGroupBusiness.Update(input));
        }

        [HttpGet("{groupId}/training")]
        public async Task<IActionResult> Training(string groupId)
        {
            return Ok(await _personGroupBusiness.Training(groupId));
        }

        [HttpPost("{groupId}/train")]
        public async Task<IActionResult> Train(string groupId)
        {
            return Ok(await _personGroupBusiness.Train(groupId));
        }

        //get employee by Id

        //add employee

        //edit employee

        //delete employee


    }
}
