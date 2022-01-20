using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete
{
    public class User : ITable
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
    }
}
