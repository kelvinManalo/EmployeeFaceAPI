using Microsoft.AspNetCore.Http;

namespace EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPersonFace
{
    public class PersonGroupPersonFaceCreateInputDto
    {
        public IFormFile FaceImage { get; set; }
    }
}
