using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroup;
using EmployeeFace.Common.Entities;
using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroup;
using EmployeeFace.Service.ServiceCollection.PersonGroup;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroup
{
    public class PersonGroupBusiness : BaseBusiness<PersonGroupBusiness>, IPersonGroupBusiness
    {

        private readonly IPersonGroupService _personGroupService;

        public PersonGroupBusiness(IMapper mapper, IPersonGroupService personGroupService) : base(mapper)
        {
            _personGroupService = personGroupService;
        }

        public async Task<ResultGeneric<PersonGroupServiceListOutputDto[]>> GetAll()
        {

            var response = await _personGroupService.List();
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupServiceListOutputDto[]>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<PersonGroupServiceListOutputDto>> GetById(string groupId)
        {

            var response = await _personGroupService.GetById(groupId);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupServiceListOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<string>> Create(PersonGroupServiceCreateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupServiceCreateInput>(input);

            var response = await _personGroupService.Create(parameters);
            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        public async Task<ResultGeneric<string>> Update(PersonGroupServiceUpdateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupServiceUpdateInput>(input);

            var response = await _personGroupService.Update(parameters);

            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        public async Task<ResultGeneric<string>> Delete(string personGroupId)
        {
            var response = await _personGroupService.Delete(personGroupId);
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

        public async Task<ResultGeneric<string>> Train(string groupId)
        {
            var response = await _personGroupService.Train(groupId);
            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        public async Task<ResultGeneric<PersonGroupGetTrainingOutputDto>> Training(string groupId)
        {
            var response = await _personGroupService.Training(groupId);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupGetTrainingOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }
    }
}
