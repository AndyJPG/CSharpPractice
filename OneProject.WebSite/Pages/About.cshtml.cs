using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OneProject.WebSite.Models;
using OneProject.WebSite.Services;

namespace OneProject.WebSite.Pages
{
    public class AboutModel : PageModel
    {

        public AboutModel(JsonFilePersonalDataService jsonFilePersonalDataService)
        {
            JsonFilePersonalDataService = jsonFilePersonalDataService;
        }

        public JsonFilePersonalDataService JsonFilePersonalDataService { get; set; }
        public Personal Personal { get; private set; }

        public void OnGet()
        {
            Personal = JsonFilePersonalDataService.GetPersonalData();
        }
    }
}
