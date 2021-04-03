using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class PortfolioDetail : Portfolio
    {
        public string Author { get; set; }
        [JsonPropertyName("completed-date")]
        public string CompletedDate { get; set; }
        public List<string> Skills { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }
        [JsonPropertyName("project-url")]
        public string ProjectUrl { get; set; }

        public override string ToString() => JsonSerializer.Serialize<PortfolioDetail>(this);
    }
}
