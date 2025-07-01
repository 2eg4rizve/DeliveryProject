// Entities/ResponseEntity/CommonResponse.cs
using System.Text.Json.Serialization;

namespace DeliveryProject.Entities.ResponseEntity
{
    public class CommonResponse
    {
        public int status_code { get; set; }
        public string message { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string status { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object data { get; set; }
    }
}
