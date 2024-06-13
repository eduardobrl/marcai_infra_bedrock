using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exams_lambda.Dto
{
    public class ResponseBody
    {
        public Dictionary<string, ResponseContent> body { get; set; }
    }

    public class ResponseContent
    {
        public string body { get; set; }
    }

    public class BedrockResponse
    {
        public string messageVersion { get; set; }
        public Response response { get; set; }
        public Dictionary<string, string> sessionAttributes { get; set; }
        public Dictionary<string, string> promptSessionAttributes { get; set; }
    }

    public class Response
    {
        public string actionGroup { get; set; }
        public string apiPath { get; set; }
        public string httpMethod { get; set; }
        public int httpStatusCode { get; set; }
        public ResponseBody responseBody { get; set; }
    }
}