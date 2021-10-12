using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroup;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroup
{
    public interface IPersonGroupBusiness
    {
        Task<ResultGeneric<PersonGroupServiceListOutputDto[]>> GetAll();

        Task<ResultGeneric<PersonGroupServiceListOutputDto>> GetById(string groupId);

        Task<ResultGeneric<string>> Create(PersonGroupServiceCreateInputDto input);

        Task<ResultGeneric<string>> Update(PersonGroupServiceUpdateInputDto input);

        Task<ResultGeneric<string>> Delete(string personGroupId);

        Task<ResultGeneric<PersonGroupGetTrainingOutputDto>> Training(string groupId);
        Task<ResultGeneric<string>> Train(string groupId);

    }
}
