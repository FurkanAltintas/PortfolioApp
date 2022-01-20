using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Interfaces
{
    public interface ICertificationService : IGenericService<Certification>
    {
        List<Certification> GetAllDate();
    }
}
