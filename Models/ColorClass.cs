using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace practice_api.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ColorClass
    {
        White = 1,

        Red = 2,

        Sparkling = 3,

        Rose = 4,

        Orange = 5
    }
}