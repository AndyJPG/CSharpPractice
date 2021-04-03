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
        [JsonPropertyName("image-url")]
        public string ImageUrl { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Portfolio>(this);
    }
}
