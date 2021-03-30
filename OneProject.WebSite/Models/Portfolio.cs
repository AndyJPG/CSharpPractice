using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class Portfolio
    {
        public string Name { get; set; }
        public List<string> Category { get; set; }
        [JsonPropertyName("image-url")]
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        [JsonPropertyName("completed-date")]
        public string CompletedDate { get; set; }
        public List<string> Skills { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }
        [JsonPropertyName("project-url")]
        public string ProjectUrl { get; set; }
    }
}
