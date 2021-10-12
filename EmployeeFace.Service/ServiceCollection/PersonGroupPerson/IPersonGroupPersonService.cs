using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPerson;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.PersonGroupPerson
{
    public interface IPersonGroupPersonService
    {
        Task<ApiResult<PersonGroupPersonListOutput[]>> List(string groupId);
        Task<ApiResult<PersonGroupPersonItemOutput>> GetById(string groupId, string personId);
        Task<ApiResult<PersonGroupPersonCreateOutput>> Create(string groupId, PersonGroupPersonCreateInput input);
        Task<ApiResult<string>> Update(string groupId, string userId, PersonGroupPersonUpdateInput input);
        Task<ApiResult<string>> Delete(string groupId, string userId);
       


    }
}
