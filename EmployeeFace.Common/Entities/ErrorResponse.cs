﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFace.Common.Entities
{
    public class ErrorResponse
    {

        //public ErrorResponse(string message, string code = null)
        //{
        //    Message = message;
        //    Code = code;
        //}

        [JsonProperty("error")]
        public ErrorMessage Error { get; set; }

        public class ErrorMessage
        {
            public string Message { get; set; }
            public string Code { get; set; }
        }

        //[JsonProperty("message")]
        //public string Message { get; set; }


        //[JsonProperty("code")]
        //public string Code { get; set; }

    }
}
