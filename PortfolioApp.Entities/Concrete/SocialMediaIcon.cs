using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete
{
    public class SocialMediaIcon : ITable
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
