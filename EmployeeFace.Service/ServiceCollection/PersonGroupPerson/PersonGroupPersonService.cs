using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.PersonGroupPerson;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.Service.ServiceCollection.PersonGroupPerson
{
    public class PersonGroupPersonService : IPersonGroupPersonService
    {
        private readonly HttpClient _client;
        private const string _baseUrl = "https://kmfaceapitest.cognitiveservices.azure.com";

        public PersonGroupPersonService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders
                .Add("Ocp-Apim-Subscription-Key", "49d7d1682fe34094ac3c82aa88b3e237");
        }

        public async Task<ApiResult<PersonGroupPersonListOutput[]>> List(string groupId)
        {

            var result = await _client.GetAsync($"face/v1.0/persongroups/{groupId}/persons");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessListRequest<PersonGroupPersonListOutput>(result, responseContents);

        }

        public async Task<ApiResult<PersonGroupPersonItemOutput>> GetById(string groupId, string personId)
        {

            var result = await _client.GetAsync($"face/v1.0/persongroups/{groupId}/persons/{personId}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupPersonItemOutput>(result, responseContents);

        }

        public async Task<ApiResult<PersonGroupPersonCreateOutput>> Create(string groupId, PersonGroupPersonCreateInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PostAsync($"face/v1.0/persongroups/{groupId}/persons", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupPersonCreateOutput>(result, responseContents);

        }

        public async Task<ApiResult<string>> Update(string groupId, string userId, PersonGroupPersonUpdateInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PatchAsync($"face/v1.0/persongroups/{groupId}/persons/{userId}", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);

        }

        public async Task<ApiResult<string>> Delete(string groupId, string userId)
        {
            var result = await _client.DeleteAsync($"face/v1.0/persongroups/{groupId}/persons/{userId}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);
        }


    }
}
