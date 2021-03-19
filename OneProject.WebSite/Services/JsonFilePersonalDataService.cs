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
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string PersonalDataJsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "personal-data.json");
            }
        }

        public Personal GetPersonalData()
        {
            using (StreamReader jsonFileReader = File.OpenText(PersonalDataJsonFileName))
            {
                return JsonSerializer.Deserialize<Personal>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
