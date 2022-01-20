using AutoMapper;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.DTO.DTOs.ExperienceDtos;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        private readonly IMapper _mapper;

        public ExperienceManager(IExperienceRepository experienceRepository, IMapper mapper)
        {
            _experienceRepository = experienceRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            if (id > 0)
            {
                var experience = _experienceRepository.GetById(id);
                if (experience != null)
                {
                    _experienceRepository.Delete(new Experience { Id = id });
                }
            }
        }

        public List<ExperienceListDto> GetAll()
        {
            var experience = _experienceRepository.GetAll();

            //if (experience.Count > 0)
            //{
            //    return _mapper.Map<List<ExperienceListDto>>(experience);
            //}

            return _mapper.Map<List<ExperienceListDto>>(experience);
        }

        public List<ExperienceListDto> GetAllOrderByDescending()
        {
            var experience = _experienceRepository.GetAllOrderByDescending();

            return _mapper.Map<List<ExperienceListDto>>(experience);
        }

        public ExperienceUpdateDto GetById(int id)
        {
            if (id > 0)
            {
                var experience = _experienceRepository.GetById(id);

                if (experience != null)
                {
                    return _mapper.Map<ExperienceUpdateDto>(experience);
                }
            }
            return null;
        }

        public Experience Insert(ExperienceAddDto experienceAddDto)
        {
            if (experienceAddDto != null)
            {
                var experience = _mapper.Map<Experience>(experienceAddDto);
                _experienceRepository.Insert(experience);
                return experience;
            }
            return null;
        }

        public Experience Update(ExperienceUpdateDto experienceUpdateDto)
        {
            if (experienceUpdateDto != null)
            {
                var experience = _mapper.Map<Experience>(experienceUpdateDto);
                _experienceRepository.Update(experience);
                return experience;
            }
            return null;
        }
    }
}
