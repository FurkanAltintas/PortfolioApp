using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete.Base
{
    public class BaseEntity2
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
