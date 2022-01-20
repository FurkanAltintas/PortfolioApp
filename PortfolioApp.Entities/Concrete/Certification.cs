using PortfolioApp.Entities.Concrete.Base;
using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete
{
    public class Certification : BaseEntity2, ITable
    {
        public string Date { get; set; }
        public DateTime DateTime { get; set; }
    }
}
