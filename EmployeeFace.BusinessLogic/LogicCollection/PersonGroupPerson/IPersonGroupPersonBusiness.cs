using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.PersonGroupPerson
{
    public interface IPersonGroupPersonBusiness
    {
        Task<ResultGeneric<PersonGroupPersonListOutputDto[]>> GetAll(string groupId);
        Task<ResultGeneric<PersonGroupPersonItemOutputDto>> GetById(string groupId, string personId);
        Task<ResultGeneric<PersonGroupPersonCreateOutputDto>> Create(string groupId, PersonGroupPersonCreateInputDto input);
        Task<ResultGeneric<string>> Update(string groupId, string personId, PersonGroupPersonUpdateInputDto input);
        Task<ResultGeneric<string>> Delete(string groupId, string personId);
        
    }
}
