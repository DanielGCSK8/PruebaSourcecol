using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PruebaSourcecol
{
    class RickMorty
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }

    }

    class Result
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}