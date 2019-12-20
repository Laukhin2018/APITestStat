using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ResponseCollection<T>
    {

        [JsonProperty("items")]
        public IEnumerable<T> Items { get; set;  }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public T Total { get; set; }
    }
}
