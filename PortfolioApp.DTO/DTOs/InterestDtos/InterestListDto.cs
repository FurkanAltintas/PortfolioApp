using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.InterestDtos
{
    public class InterestListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
