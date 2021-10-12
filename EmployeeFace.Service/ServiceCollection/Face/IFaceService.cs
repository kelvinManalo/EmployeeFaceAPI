using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.Face;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.Face
{
    public interface IFaceService
    {
        Task<ApiResult<FaceDetectOutput[]>> Detect(FaceDetectInput input);
        Task<ApiResult<FaceIdentifyOutput[]>> Identify(FaceIdentifyInput input);
    }
}
