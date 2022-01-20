using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.SkillDtos
{
    public class SkillAddDto : IDto
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
