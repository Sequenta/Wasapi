using System;
using System.Collections.Generic;
using System.Linq;

namespace Wasapi
{
    public class Response
    {
        public int Code { get; set; }

        public string ErrorMessage { get; set; }

        public IEnumerable<AssociationResult> Result { get; set; }

        public static Response Error(int code)
        {
            return new Response
            {
                Code = code,
                ErrorMessage = ((ResponseCode)code).GetDescription(),
                Result = null
            };
        }

        public static Response Success(IEnumerable<AssociationResult> result)
        {
            return new Response
            {
                Code = (int)ResponseCode.Ok,
                ErrorMessage = string.Empty,
                Result = result
            };
        }
    }
}