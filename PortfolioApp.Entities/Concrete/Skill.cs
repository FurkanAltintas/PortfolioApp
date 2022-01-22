using PortfolioApp.Entities.Concrete.Base;
using PortfolioApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Entities.Concrete
{
    public class Skill : BaseEntity2, ITable
    {
        /* Select c.Id as CategoryId, s.CategoryId as SkillCategoryId, c.Name, s.Description 
              from Skills s Join SkillCategories c ON s.CategoryId=c.Id */
        public int SkillCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string Skills { get; set; }
    }
}
