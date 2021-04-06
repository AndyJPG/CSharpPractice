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

        private string PortfoliosBriefJsonFileName
        {
            get
            {
                // Use webHostEnvironment service to get wwwrootpath
                // Different host environment has different root path
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "portfolio-brief-data.json");
            }
        }

        public string PortfoliosJsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "portfolio-data.json");
            }
        }

        // Service to retrieve data from json file
        public PortfolioBrief GetPortfoliosBrief()
        {
            try
            {
                // IO operation gabage collection doesn't automaticly managed by C# so we use using keyword
                // It can be properly terminated without occupy the memory
                using (StreamReader jsonFileReader = File.OpenText(PortfoliosBriefJsonFileName))
                {
                    // Return deserialized personal object
                    //JObject portfolioJson = JObject.Parse(jsonFileReader.ReadToEnd());
                    //return portfolioJson["portfolios"].ToObject<List<Portfolio>>();
                    return JsonSerializer.Deserialize<PortfolioBrief>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException($"{PortfoliosBriefJsonFileName} document can't be found", e);
            }
            
        }

        // Service to get portfolio by id
        public PortfolioDetail GetPortfolioById(string id)
        {
            List<PortfolioDetail> portfolios;

            try
            {
                using (StreamReader jsonFileReader = File.OpenText(PortfoliosJsonFileName))
                {
                    portfolios = JsonSerializer.Deserialize<List<PortfolioDetail>>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException($"{PortfoliosJsonFileName} document can't be found", e);
            }

            foreach (PortfolioDetail portfolio in portfolios)
            {
                if (portfolio.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return portfolio;
                }
            }

            return new PortfolioDetail();
            // throw new KeyNotFoundException($"Id {id} can't be found in database");
        }
    }
}
