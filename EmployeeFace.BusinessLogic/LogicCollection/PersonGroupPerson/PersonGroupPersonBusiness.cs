using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson;
using EmployeeFace.Common.Entities;
using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPerson;
using EmployeeFace.Service.ServiceCollection.PersonGroupPerson;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPerson
{
    public class PersonGroupPersonBusiness : BaseBusiness<PersonGroupPersonBusiness>, IPersonGroupPersonBusiness
    {
        private readonly IPersonGroupPersonService _personGroupPersonService;

        public PersonGroupPersonBusiness(IMapper mapper, IPersonGroupPersonService personGroupPersonService) : base(mapper)
        {
            _personGroupPersonService = personGroupPersonService;
        }

        public async Task<ResultGeneric<PersonGroupPersonCreateOutputDto>> Create(string groupId, PersonGroupPersonCreateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupPersonCreateInput>(input);

            var response = await _personGroupPersonService.Create(groupId, parameters);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupPersonCreateOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<string>> Delete(string groupId, string personId)
        {
            var response = await _personGroupPersonService.Delete(groupId, personId);
            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        public async Task<ResultGeneric<PersonGroupPersonListOutputDto[]>> GetAll(string groupId)
        {
            var response = await _personGroupPersonService.List(groupId);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupPersonListOutputDto[]>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<PersonGroupPersonItemOutputDto>> GetById(string groupId, string personId)
        {
            var response = await _personGroupPersonService.GetById(groupId, personId);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupPersonItemOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }


        public async Task<ResultGeneric<string>> Update(string groupId, string personId, PersonGroupPersonUpdateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupPersonUpdateInput>(input);

            var response = await _personGroupPersonService.Update(groupId, personId, parameters);

            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        protected override void ValidateResponse<TModel>(ApiResult<TModel> response)
        {
            if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Accepted)
            {
                var requestResult = DeserializeResult<ErrorResponse>(response.RawData);
                throw GetBaseException(requestResult);
            }
        }
    }
}
