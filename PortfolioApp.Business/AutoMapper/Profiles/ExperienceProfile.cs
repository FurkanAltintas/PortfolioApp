using AutoMapper;
using PortfolioApp.DTO.DTOs.ExperienceDtos;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.AutoMapper.Profiles
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<ExperienceListDto, Experience>();
            CreateMap<Experience, ExperienceListDto>();

            CreateMap<ExperienceAddDto, Experience>();
            CreateMap<Experience, ExperienceAddDto>();

            CreateMap<ExperienceUpdateDto, Experience>();
            CreateMap<Experience, ExperienceUpdateDto>();
        }
    }
}
