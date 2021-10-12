using Microsoft.AspNetCore.Http;

namespace EmployeeFace.BusinessLogic.DataTransferObjects.Face
{
    public class FaceDetectInputDto
    {
        public IFormFile FaceImage { get; set; }
    }
}
