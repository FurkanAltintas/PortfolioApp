using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.SkillCategoryDtos
{
    internal class SkillCategoryListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
