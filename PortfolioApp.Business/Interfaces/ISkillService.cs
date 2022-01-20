using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Interfaces
{
    public interface ISkillService : IGenericService<Skill>
    {
        List<Skill> JoinCategory();
    }
}
