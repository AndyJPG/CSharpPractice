using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class Education
    {
        [JsonPropertyName("school-logo")]
        public string SchoolLogo { get; set; }

        [JsonPropertyName("school-name")]
        public string SchoolName { get; set; }

        [JsonPropertyName("school-major")]
        public string SchoolMajor { get; set; }

        [JsonPropertyName("start-date")]
        public string StartDate { get; set; }

        [JsonPropertyName("end-date")]
        public string EndDate { get; set; }

        public string Location { get; set; }
        public List<string> Body { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Education>(this);
    }
}
