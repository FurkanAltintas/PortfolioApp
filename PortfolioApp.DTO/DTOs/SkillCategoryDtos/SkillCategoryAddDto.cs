using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.SkillCategoryDtos
{
    public class SkillCategoryAddDto: IDto
    {
        public string Name { get; set; }
    }
}
