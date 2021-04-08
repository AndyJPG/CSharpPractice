using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OneProject.WebSite.Models;
using OneProject.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PortfolioDetail> GetPortfolioById(string id)
        {
            try
            {
                return PortfolioService.GetPortfolioById(id);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public PortfolioBrief GetPortfolioBrief()
        {
            return PortfolioService.GetPortfoliosBrief();
        }
    }
}
