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
    public class PortfolioModel : PageModel
    {
        public PortfolioModel(JsonFilePortfolioService portfolioService)
        {
            PortfolioService = portfolioService;
        }

        public JsonFilePortfolioService PortfolioService { get; set; }
        public List<Portfolio> Portfolios { get; set; }

        public void OnGet()
        {
            Portfolios = PortfolioService.GetPortfoliosBrief();
        }
    }
}
