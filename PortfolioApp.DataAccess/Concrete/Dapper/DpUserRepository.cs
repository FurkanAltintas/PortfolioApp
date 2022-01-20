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
    public class DpUserRepository : DpGenericRepository<User>, IUserRepository
    {
        private readonly IDbConnection _connection;
        public DpUserRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public bool CheckUser(string userName, string password)
        {
            //var user = _connection.QueryFirstOrDefault<User>("select * from Users where UserName=" + userName + " and Password " + password + " ");

            var user = _connection.QueryFirstOrDefault<User>("select * from Users where UserName = @userName and Password = password", new
            {
                userName = userName,
                password = password
            });

            return user != null;
        }

        public User FindByName(string userName)
        {
            return _connection.QueryFirstOrDefault<User>("select * from Users where UserName = @userName", new
            {
                userName = userName
            });
        }

        public User GetUser()
        {
            return _connection.QueryFirstOrDefault<User>("select top 1 * from Users order by Id desc");
        }
    }
}
