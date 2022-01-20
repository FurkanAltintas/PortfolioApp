using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.SocialMediaIconDtos
{
    public class SocialMediaIconAddDto : IDto
    {
        public int UserId { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
