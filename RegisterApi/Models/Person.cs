using Newtonsoft.Json;

namespace RegisterApi.Models 
{
    public class Person {
        [JsonProperty("first-name")]
        public string FirstName { get; set; }

        [JsonProperty("last-name")]
        public string LastName { get; set; }
    }
}