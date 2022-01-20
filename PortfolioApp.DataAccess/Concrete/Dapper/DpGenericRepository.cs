using Dapper.Contrib.Extensions;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IDbConnection _connection;

        public DpGenericRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        /* 
         * IDbConnection ile ilgili connectionı taşıyabiliyoruz. 
         */

        public void Delete(TEntity entity)
        {
            _connection.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _connection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _connection.Get<TEntity>(id);
        }

        public TEntity Insert(TEntity entity)
        {
            _connection.Insert(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _connection.Update(entity);
            return entity;
        }
    }
}
