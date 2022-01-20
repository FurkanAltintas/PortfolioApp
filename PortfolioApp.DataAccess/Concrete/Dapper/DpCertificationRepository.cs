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
    public class DpCertificationRepository : DpGenericRepository<Certification>, ICertificationRepository
    {
        private readonly IDbConnection _connection;
        public DpCertificationRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<Certification> GetAllDate()
        {
            return _connection.Query<Certification>("select c.DateTime, c.Description from Certifications c order by DateTime desc").ToList();
        }
    }
}
