using PortfolioApp.Business.Interfaces;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericRepository<TEntity> _genericRepository;

        public GenericManager(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Delete(TEntity entity)
        {
            _genericRepository.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public TEntity Insert(TEntity entity)
        {
            _genericRepository.Insert(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _genericRepository.Update(entity);
            return entity;
        }
    }
}
