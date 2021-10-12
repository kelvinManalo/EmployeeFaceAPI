using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
