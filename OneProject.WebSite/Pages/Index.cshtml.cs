﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OneProject.WebSite.Models;
using OneProject.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneProject.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFilePersonalDataService PersonalDataService;
        public Personal Personal { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, 
            JsonFilePersonalDataService jsonFilePersonalDataService)
        {
            _logger = logger;
            PersonalDataService = jsonFilePersonalDataService;
        }

        public void OnGet()
        {
            Personal = PersonalDataService.GetPersonalData();
        }
    }
}
