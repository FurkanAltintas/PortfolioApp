using PortfolioApp.Business.Interfaces;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Concrete
{
    public class CertificationManager : GenericManager<Certification>, ICertificationService
    {
        private readonly IGenericRepository<Certification> _certificationGenericRepository;
        private readonly ICertificationRepository _certificationRepository;

        public CertificationManager(IGenericRepository<Certification> certificationGenericRepository, ICertificationRepository certificationRepository) : base(certificationGenericRepository)
        {
            _certificationGenericRepository = certificationGenericRepository;
            _certificationRepository = certificationRepository;
        }

        public List<Certification> GetAllDate()
        {
            return _certificationRepository.GetAllDate();
        }
    }
}
