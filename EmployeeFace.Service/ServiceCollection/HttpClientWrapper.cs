using EmployeeFace.Service.Entities;
using Newtonsoft.Json;
using System.Net.Http;

namespace EmployeeFace.Service.ServiceCollection
{
    public class HttpClientWrapper
    {
        public static ApiResult<TReturn> ProcessRequest<TReturn>(HttpResponseMessage response, string responseContents)
        {
            var result = new ApiResult<TReturn>();

            if (response.IsSuccessStatusCode)
                result.Data = JsonConvert.DeserializeObject<TReturn>(responseContents);
            else
                result.RawData = responseContents;

            result.StatusCode = response.StatusCode;

            return result;
        }

        public static ApiResult<TReturn[]> ProcessListRequest<TReturn>(HttpResponseMessage response, string responseContents)
        {
            var result = new ApiResult<TReturn[]>();

            if (response.IsSuccessStatusCode)
                result.Data = JsonConvert.DeserializeObject<TReturn[]>(responseContents);
            else
                result.RawData = responseContents;

            result.StatusCode = response.StatusCode;

            return result;
        }
    }
}
