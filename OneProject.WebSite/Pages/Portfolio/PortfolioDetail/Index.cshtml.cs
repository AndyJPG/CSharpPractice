using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OneProject.WebSite.Services;

namespace OneProject.WebSite.Pages.PortfolioDetail
{
    public class IndexModel : PageModel
    {
        public IndexModel(JsonFilePortfolioService portfolioService)
        {
            PortfolioService = portfolioService;
        }

        public JsonFilePortfolioService PortfolioService { get; set; }


        [BindProperty(Name = "portfolio_id", SupportsGet = true)]
        public string PortfolioId { get; set; }

        public Models.PortfolioDetail portfolio { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                portfolio = PortfolioService.GetPortfolioById(PortfolioId);
                return Page();
            }
            catch (Exception e)
            {
                return Redirect($"/Error?code=404&message={e.Message}");
            }

            //portfolio = PortfolioService.GetPortfolioById(PortfolioId);
        }
    }
}
