using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class Portfolio
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Category { get; set; }
        [JsonProperty("image-url")]
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        [JsonProperty("completed-date")]
        public string CompletedDate { get; set; }
        public List<string> Skills { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }
        [JsonProperty("project-url")]
        public string ProjectUrl { get; set; }

        public override string ToString() => System.Text.Json.JsonSerializer.Serialize<Portfolio>(this);
    }
}
