using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PracticeApp1
{
    class ReadJsonFile
    {
        public ReadJsonFile()
        {

        }

        public static void ReadPortfolioDataToJson()
        {
            using (StreamReader jsonFileReader = File.OpenText("D:\\Documents\\Andy\\C#\\PracticeApp1\\PracticeApp1\\data\\portfolio-data.json"))
            {
                JObject json = JObject.Parse(jsonFileReader.ReadToEnd());
                var portfolios = json["portfolios"].ToObject<List<Portfolio>>();
                Console.WriteLine(portfolios[0].Name);
            }
        }
    }

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
