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
        public PortfolioBrief PortfolioBrief { get; set; }

        public int NumberOfPortfolios { get; set; }

        public void OnGet([FromQuery(Name = "number_of_portfolios")] int numberOfPortfolios = 3)
        {
            // Obtain portfolios
            PortfolioBrief = PortfolioService.GetPortfoliosBrief();

            // Present how many portfolios
            if (numberOfPortfolios >= PortfolioBrief.Portfolios.Count)
            {
                NumberOfPortfolios = PortfolioBrief.Portfolios.Count;
            }
            else
            {
                NumberOfPortfolios = numberOfPortfolios;
            }
        }
    }
}
