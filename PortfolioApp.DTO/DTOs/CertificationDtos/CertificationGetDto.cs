using PortfolioApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DTO.DTOs.CertificationDtos
{
    public class CertificationGetDto : IDto
    {
        public string Description { get; set; }
        public string Date { get; set; }
        public DateTime DateTime { get; set; }
    }
}
