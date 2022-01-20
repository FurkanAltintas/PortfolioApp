using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.SkillDtos
{
    public class SkillGetCategoryListDto : IDto
    {
        /*
        
        Select c.Id as CategoryId, s.Id as SkillId, c.Name, s.Description from Skills s Join SkillCategories c ON s.CategoryId=c.Id

         */
        public int Id { get; set; }
        public int SkillCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
