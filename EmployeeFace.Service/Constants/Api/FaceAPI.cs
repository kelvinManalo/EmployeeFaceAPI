using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.Service.Constants.Api
{
    public class FaceAPI
    {
        private const string _baseUrl = "https://kmfaceapitest.cognitiveservices.azure.com";

        public static string GetAllPersonGroups => $"{_baseUrl}/face/v1.0/persongroups?returnRecognitionModel=true";

        public static string PersonGroup(int personGroupId) => $"{_baseUrl}/face/v1.0/persongroups/{personGroupId}";

        public static string GetAllPersons(int personGroupId) => $"{_baseUrl}/face/v1.0/persongroups/{personGroupId}/persons";

        public static string CreatePerson(int personGroupId) => $"{_baseUrl}/face/v1.0/persongroups/{personGroupId}/persons";

        public static string UpdatePerson(int personGroupId, string personId) => $"{_baseUrl}/face/v1.0/persongroups/{personGroupId}/persons/{personId}";

        public static string DeletePerson(int personGroupId, string personId) => $"{_baseUrl}/face/v1.0/persongroups/{personGroupId}/persons/{personId}";

     



    }
}
