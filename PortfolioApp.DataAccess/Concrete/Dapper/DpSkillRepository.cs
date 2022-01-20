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
    public class DpSkillRepository : DpGenericRepository<Skill>, ISkillRepository
    {
        private readonly IDbConnection _connection;
        public DpSkillRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<Skill> JoinCategory()
        {
            return _connection.Query<Skill>("Select s.Id, c.Id as CategoryId, s.CategoryId as SkillCategoryId, c.Name, s.Description from Skills s Join SkillCategories c ON s.CategoryId=c.Id").ToList();
        }
    }
}
