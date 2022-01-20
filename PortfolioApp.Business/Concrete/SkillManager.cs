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
    public class SkillManager : GenericManager<Skill>, ISkillService
    {
        private readonly IGenericRepository<Skill> _skillGenericRepository;
        private readonly ISkillRepository _skillRepository;
        public SkillManager(IGenericRepository<Skill> skillGenericRepository, ISkillRepository skillRepository) : base(skillRepository)
        {
            _skillGenericRepository = skillGenericRepository;
            _skillRepository = skillRepository;
        }

        public List<Skill> JoinCategory()
        {
            return _skillRepository.JoinCategory();
        }
    }
}
