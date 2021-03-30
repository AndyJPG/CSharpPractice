using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OneProject.WebSite.Models;
using OneProject.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OneProject.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        public PortfolioController(JsonFilePortfolioService portfolioService)
        {
            PortfolioService = portfolioService;
        }

        public JsonFilePortfolioService PortfolioService { get; }

        [HttpGet]
        public List<Portfolio> Get()
        {
            //return PortfolioService.GetPortfolios();
            return PortfolioService.GetPortfolios();
        }
    }
}
