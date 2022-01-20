using PortfolioApp.DTO.DTOs.ExperienceDtos;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Interfaces
{
    public interface IExperienceService
    {
        List<ExperienceListDto> GetAll();
        List<ExperienceListDto> GetAllOrderByDescending();
        ExperienceUpdateDto GetById(int id);
        Experience Insert(ExperienceAddDto experienceAddDto);
        Experience Update(ExperienceUpdateDto experienceUpdateDto);
        void Delete(int id);
    }
}
