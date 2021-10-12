using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPersonFace;
using EmployeeFace.Common.Entities;
using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPersonFace;
using EmployeeFace.Service.ServiceCollection.PersonGroupPersonFace;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPersonFace
{
    public class PersonGroupPersonFaceBusiness : BaseBusiness<PersonGroupPersonFaceBusiness>, IPersonGroupPersonFaceBusiness
    {
        private readonly IPersonGroupPersonFaceService _personGroupPersonFaceService;

        public PersonGroupPersonFaceBusiness(IMapper mapper, IPersonGroupPersonFaceService personGroupPersonFaceService) : base(mapper)
        {
            _personGroupPersonFaceService = personGroupPersonFaceService;
        }

        public async Task<ResultGeneric<PersonGroupPersonFaceGetOutputDto>> GetById(string groupId, string personId, string persistedFaceId)
        {
            var response = await _personGroupPersonFaceService.GetById(groupId, personId, persistedFaceId);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupPersonFaceGetOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<PersonGroupPersonFaceCreateOutputDto>> Create(string groupId, string personId, PersonGroupPersonFaceCreateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupPersonFaceCreateInput>(input);

            var response = await _personGroupPersonFaceService.Create(groupId, personId, parameters);
            ValidateResponse(response);

            var result = Mapper.Map<PersonGroupPersonFaceCreateOutputDto>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<string>> Update(string groupId, string personId, string persistedFaceId, PersonGroupPersonFaceUpdateInputDto input)
        {
            var parameters = Mapper.Map<PersonGroupPersonFaceUpdateInput>(input);

            var response = await _personGroupPersonFaceService.Update(groupId, personId, persistedFaceId, parameters);

            ValidateResponse(response);

            return GetResultGeneric(response.Data);
        }

        public async Task<ResultGeneric<string>> Delete(string groupId, string personId, string persistedFaceId)
        {
            var response = await _personGroupPersonFaceService.Delete(groupId, personId, persistedFaceId);
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
