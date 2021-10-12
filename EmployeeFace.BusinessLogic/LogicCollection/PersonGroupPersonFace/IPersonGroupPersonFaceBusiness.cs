using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPersonFace;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPersonFace
{
    public interface IPersonGroupPersonFaceBusiness
    {
        Task<ResultGeneric<PersonGroupPersonFaceCreateOutputDto>> Create(string groupId, string personId, PersonGroupPersonFaceCreateInputDto input);
        Task<ResultGeneric<string>> Update(string groupId, string personId, string persistedFaceId, PersonGroupPersonFaceUpdateInputDto input);
        Task<ResultGeneric<string>> Delete(string groupId, string personId, string persistedFaceId);
        Task<ResultGeneric<PersonGroupPersonFaceGetOutputDto>> GetById(string groupId, string personId, string persistedFaceId);
    }
}
