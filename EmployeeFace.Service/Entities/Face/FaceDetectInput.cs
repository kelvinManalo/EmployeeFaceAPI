using Microsoft.AspNetCore.Http;

namespace EmployeeFace.Service.Entities.Face
{
    public class FaceDetectInput
    {
        public IFormFile FaceImage { get; set; }
    }
}
