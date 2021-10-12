using EmployeeFace.Service.Entities;
using EmployeeFace.Service.Entities.Face;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeFace.Service.ServiceCollection.Face
{
    public class FaceService : IFaceService
    {
        private readonly HttpClient _client;
        private const string _baseUrl = "https://kmfaceapitest.cognitiveservices.azure.com";

        public FaceService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders
                .Add("Ocp-Apim-Subscription-Key", "49d7d1682fe34094ac3c82aa88b3e237");
        }

        public async Task<ApiResult<FaceDetectOutput[]>> Detect(FaceDetectInput input)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["returnFaceAttributes"] = "accessories,age,blur,emotion,exposure,facialhair,gender,glasses,hair,headpose,makeup,noise,occlusion,smile";
            query["returnFaceId"] = "true";
            query["returnFaceLandmarks"] = "true";
            query["recognitionModel"] = "recognition_01";
            query["returnRecognitionModel"] = "true";
            query["detectionModel"] = "detection_01";
            string queryString = query.ToString();

            using var stream = new MemoryStream();
            input.FaceImage.CopyTo(stream);

            using var content = new ByteArrayContent(stream.ToArray());
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            var result = await _client.PostAsync($"face/v1.0/detect?{queryString}", content);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessListRequest<FaceDetectOutput>(result, responseContents);
        }

        public async Task<ApiResult<FaceIdentifyOutput[]>> Identify(FaceIdentifyInput input)
        {

            var requestObject = JsonConvert.SerializeObject(input);

            var stringContent = new StringContent(requestObject, Encoding.UTF8, "application/json");

            var result = await _client.PostAsync($"face/v1.0/identify", stringContent);

            var responseContents = await result.Content.ReadAsStringAsync();

            return HttpClientWrapper.ProcessListRequest<FaceIdentifyOutput>(result, responseContents);
        }
    }
}
