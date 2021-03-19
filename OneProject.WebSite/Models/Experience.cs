using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class Experience
    {
        [JsonPropertyName("company-name")]
        public string CompanyName { get; set; }
        [JsonPropertyName("company-url")]
        public string CompanyUrl { get; set; }
        public string Position { get; set; }
        [JsonPropertyName("start-date")]
        public string StartDate { get; set; }
        [JsonPropertyName("end-date")]
        public string EndDate { get; set; }
        public string Location { get; set; }
        public List<string> Body { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Experience>(this);
    }
}
