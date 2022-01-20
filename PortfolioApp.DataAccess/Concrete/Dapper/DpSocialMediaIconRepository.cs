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
    public class DpSocialMediaIconRepository : DpGenericRepository<SocialMediaIcon>, ISocialMediaIconRepository
    {
        private readonly IDbConnection _connection;
        public DpSocialMediaIconRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        List<SocialMediaIcon> ISocialMediaIconRepository.GetByUserId(int userId)
        {
            return _connection.Query<SocialMediaIcon>("Select * from SocialMediaIcons where UserId = @id", new
            {
                id = userId
            }).ToList();
        }
    }
}
