using PortfolioApp.Entities.Concrete.Base;
using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete
{
    public class Education : BaseEntity, ITable
    {
        public string Grade { get; set; }
    }
}
