using PortfolioApp.DTO.DTOs.InterestDtos;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Models
{
    public class InterestViewModel
    {
        public List<InterestListDto> Interests { get; set; }
    }
}