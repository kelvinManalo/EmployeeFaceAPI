using EmployeeFace.Service.Entities.PersonGroup;
using EmployeeFace.Service.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeFace.Service.ServiceCollection.PersonGroup
{
    public class PersonGroupService : IPersonGroupService
    {

        private HttpClient _client;
        private const string _baseUrl = "https://kmfaceapitest.cognitiveservices.azure.com/";


        public PersonGroupService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders
                .Add("Ocp-Apim-Subscription-Key", "49d7d1682fe34094ac3c82aa88b3e237");
        }

        public async Task<ApiResult<string>> Create(PersonGroupServiceCreateInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PutAsync($"face/v1.0/persongroups/{input.GroupId}", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);
            
        }

        public async Task<ApiResult<string>> Update(PersonGroupServiceUpdateInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PatchAsync($"face/v1.0/persongroups/{input.GroupId}", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);

        }

        public async Task<ApiResult<PersonGroupServiceListOutput[]>> List()
        {

            var query = HttpUtility.ParseQueryString(string.Empty);
            query["returnRecognitionModel"] = "true";
            string queryString = query.ToString();

            var result = await _client.GetAsync($"face/v1.0/persongroups?{queryString}");


            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessListRequest<PersonGroupServiceListOutput>(result, responseContents);            

        }

        public async Task<ApiResult<PersonGroupServiceListOutput>> GetById(string groupId)
        {

            var query = HttpUtility.ParseQueryString(string.Empty);
            query["returnRecognitionModel"] = "true";
            string queryString = query.ToString();

            var result = await _client.GetAsync($"face/v1.0/persongroups/{groupId}?{queryString}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupServiceListOutput>(result, responseContents);

        }

        public async Task<ApiResult<string>> Delete(string groupId)
        {
            var result = await _client.DeleteAsync($"face/v1.0/persongroups/{groupId}");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);
        }

        public async Task<ApiResult<PersonGroupGetTrainingOutput>> Training(string groupId)
        {

            var result = await _client.GetAsync($"face/v1.0/persongroups/{groupId}/training");

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<PersonGroupGetTrainingOutput>(result, responseContents);

        }

        public async Task<ApiResult<string>> Train(string groupId)
        {

            var result = await _client.PostAsync($"face/v1.0/persongroups/{groupId}/train", null);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessRequest<string>(result, responseContents);

        }








    }
}
