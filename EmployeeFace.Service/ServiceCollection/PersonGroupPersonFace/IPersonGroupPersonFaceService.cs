using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPersonFace;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.PersonGroupPersonFace
{
    public interface IPersonGroupPersonFaceService
    {
        Task<ApiResult<PersonGroupPersonFaceGetOutput>> GetById(string groupId, string personId, string persistedFaceId);
        Task<ApiResult<PersonGroupPersonFaceCreateOutput>> Create(string groupId, string personId, PersonGroupPersonFaceCreateInput input);
        Task<ApiResult<string>> Update(string groupId, string personId, string persistedFaceId, PersonGroupPersonFaceUpdateInput input);
        Task<ApiResult<string>> Delete(string groupId, string personId, string persistedFaceId);
    }
}
