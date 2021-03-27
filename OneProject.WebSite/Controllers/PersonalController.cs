using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneProject.WebSite.Models;
using OneProject.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneProject.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        public PersonalController(JsonFilePersonalDataService personalDataService)
        {
            PersonalDataService = personalDataService;
        }

        public JsonFilePersonalDataService PersonalDataService { get; }

        [HttpGet]
        public Personal Get()
        {
            return PersonalDataService.GetPersonalData();
        }
    }
}
