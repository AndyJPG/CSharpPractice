using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using OneProject.WebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OneProject.WebSite.Services
{
    public class JsonFilePortfolioService
    {
        public JsonFilePortfolioService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string PortfolioJsonFileName
        {
            get
            {
                // Use webHostEnvironment service to get wwwrootpath
                // Different host environment has different root path
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "portfolio-data.json");
            }
        }

        // Service to retrieve data from json file
        public List<Portfolio> GetPortfolios()
        {
            // IO operation gabage collection doesn't automaticly managed by C# so we use using keyword
            // It can be properly terminated without occupy the memory
            using (StreamReader jsonFileReader = File.OpenText(PortfolioJsonFileName))
            {
                // Return deserialized personal object
                JObject portfolioJson = JObject.Parse(jsonFileReader.ReadToEnd());
                return portfolioJson["portfolios"].ToObject<List<Portfolio>>();
            }
        }
    }
}
