using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DataAccess.Interfaces
{
    public interface ICertificationRepository
    {
        List<Certification> GetAllDate();
    }
}
