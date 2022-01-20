using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DataAccess.Concrete.Dapper
{
    public class DpInterestRepository : DpGenericRepository<Interest>, IInterestRepository
    {
        IDbConnection _connection;
        public DpInterestRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }
    }
}
