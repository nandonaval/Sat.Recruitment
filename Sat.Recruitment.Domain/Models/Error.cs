using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Sat.Recruitment.Domain.Models
{
    public class Error
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonSerializer.Serialize(this);

    }
}
