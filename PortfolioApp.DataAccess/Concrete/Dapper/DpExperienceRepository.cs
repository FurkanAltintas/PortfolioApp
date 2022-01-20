using Dapper;
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
    public class DpExperienceRepository : DpGenericRepository<Experience>, IExperienceRepository
    {
        private readonly IDbConnection _connection;
        public DpExperienceRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<Experience> GetAllOrderByDescending()
        {
            return _connection.Query<Experience>("select * from Experiences order by StartDate desc").ToList();
        }
    }
}
