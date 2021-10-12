using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.Face;
using EmployeeFace.Common.Entities;
using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.Face;
using EmployeeFace.Service.ServiceCollection.Face;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.Face
{
    public class FaceBusiness : BaseBusiness<FaceBusiness>, IFaceBusiness
    {
        private readonly IFaceService _faceService;

        public FaceBusiness(IMapper mapper, IFaceService faceService) : base(mapper)
        {
            _faceService = faceService;
        }

        public async Task<ResultGeneric<FaceDetectOutputDto[]>> Detect(FaceDetectInputDto input)
        {
            var parameters = Mapper.Map<FaceDetectInput>(input);

            var response = await _faceService.Detect(parameters);
            ValidateResponse(response);

            var result = Mapper.Map<FaceDetectOutputDto[]>(response?.Data);

            return GetResultGeneric(result);
        }

        public async Task<ResultGeneric<FaceIdentifyOutputDto[]>> Identify(FaceIdentifyInputDto input)
        {
            var parameters = Mapper.Map<FaceIdentifyInput>(input);

            var response = await _faceService.Identify(parameters);
            ValidateResponse(response);

            var result = Mapper.Map<FaceIdentifyOutputDto[]>(response?.Data);

            return GetResultGeneric(result);
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
