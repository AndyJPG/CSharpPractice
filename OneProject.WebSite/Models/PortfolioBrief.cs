using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class PortfolioBrief
    {
        public List<string> Categories { get; set; }
        public List<Portfolio> Portfolios { get; set; }

        public override string ToString() => JsonSerializer.Serialize<PortfolioBrief>(this);
    }
}
