using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroup;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.PersonGroup
{
    public interface IPersonGroupService
    {
        Task<ApiResult<string>> Create(PersonGroupServiceCreateInput input);
        Task<ApiResult<string>> Update(PersonGroupServiceUpdateInput input);
        Task<ApiResult<PersonGroupServiceListOutput[]>> List();
        Task<ApiResult<PersonGroupServiceListOutput>> GetById(string groupId);
        Task<ApiResult<string>> Delete(string groupId);
        Task<ApiResult<PersonGroupGetTrainingOutput>> Training(string groupId);
        Task<ApiResult<string>> Train(string groupId);

    }
}
