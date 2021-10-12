using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPersonFace;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.PersonGroupPersonFace
{
    public class PersonGroupPersonFaceService : IPersonGroupPersonFaceService
    {
        private readonly HttpClient _client;
        private const string _baseUrl = "https://kmfaceapitest.cognitiveservices.azure.com";

        public PersonGroupPersonFaceService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders
                .Add("Ocp-Apim-Subscription-Key", "49d7d1682fe34094ac3c82aa88b3e237");
        }
        public async Task<ApiResult<PersonGroupPersonFaceCreateOutput>> Create(string groupId, string personId, PersonGroupPersonFaceCreateInput input)
        {

            using var stream = new MemoryStream();
            input.FaceImage.CopyTo(stream);

            using var content = new ByteArrayContent(stream.ToArray());
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            var result = await _client.PostAsync($"face/v1.0/persongroups/{groupId}/persons/{personId}/persistedFaces", content);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupPersonFaceCreateOutput>(result, responseContents);
        }

        public async Task<ApiResult<string>> Update(string groupId, string personId, string persistedFaceId, PersonGroupPersonFaceUpdateInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PatchAsync($"face/v1.0/persongroups/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);
        }

        public async Task<ApiResult<string>> Delete(string groupId, string personId, string persistedFaceId)
        {
            var result = await _client.DeleteAsync($"face/v1.0/persongroups/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);
        }


        public async Task<ApiResult<PersonGroupPersonFaceGetOutput>> GetById(string groupId, string personId, string persistedFaceId)
        {
            var result = await _client.GetAsync($"face/v1.0/persongroups/{groupId}/persons/{personId}/persistedFaces/{persistedFaceId}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupPersonFaceGetOutput>(result, responseContents);
        }
    }
}
