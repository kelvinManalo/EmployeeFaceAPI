using System.Net;

namespace EmployeeFace.Service.Entities
{
    public class ApiResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string RawData { get; set; }

    }

    public class ApiResult<T> : ApiResult
    {
        public T Data { get; set; }
    }
}
