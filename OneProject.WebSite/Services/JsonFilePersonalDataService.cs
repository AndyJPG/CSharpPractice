using Microsoft.AspNetCore.Hosting;
using OneProject.WebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OneProject.WebSite.Services
{
    public class JsonFilePersonalDataService
    {
        public JsonFilePersonalDataService(IWebHostEnvironment webHostEnvironment)
        {
            // Inject native IWebHostEnvironment service
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string PersonalDataJsonFileName
        {
            get
            {
                // Use webHostEnvironment service to get wwwrootpath
                // Different host environment has different root path
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "personal-data.json");
            }
        }

        // Service to retrieve data from json file
        public Personal GetPersonalData()
        {
            // IO operation gabage collection doesn't automaticly managed by C# so we use using keyword
            // It can be properly terminated without occupy the memory
            using (StreamReader jsonFileReader = File.OpenText(PersonalDataJsonFileName))
            {
                // Return deserialized personal object
                return JsonSerializer.Deserialize<Personal>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
