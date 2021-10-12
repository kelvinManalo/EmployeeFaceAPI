using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.BusinessLogic.DataTransferObjects.Face;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.BusinessLogic.LogicCollection.Face
{
    public interface IFaceBusiness
    {
        Task<ResultGeneric<FaceDetectOutputDto[]>> Detect(FaceDetectInputDto input);
        Task<ResultGeneric<FaceIdentifyOutputDto[]>> Identify(FaceIdentifyInputDto input);
    }
}
