using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Common
{
    public class Response
    {
        public ResponseStatus Status { get; set; } = ResponseStatus.Success;
        public string StatusDescription { get { return Status.ToString(); } }
        public string Errors { get; set; }
        public IEnumerable<Object> Content { get; set; }
    }

    public enum ResponseStatus
    {
        Success,
        Unprocessable,
        Unauthorized,
        NotFound,
        SuccessNoContent
    }

}


