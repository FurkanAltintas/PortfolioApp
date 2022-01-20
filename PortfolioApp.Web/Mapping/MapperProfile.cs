using AutoMapper;
using PortfolioApp.DTO.DTOs.CertificationDtos;
using PortfolioApp.DTO.DTOs.EducationDtos;
using PortfolioApp.DTO.DTOs.InterestDtos;
using PortfolioApp.DTO.DTOs.SkillDtos;
using PortfolioApp.DTO.DTOs.SocialMediaIconDtos;
using PortfolioApp.DTO.DTOs.UserDtos;
using PortfolioApp.Entities.Concrete;

namespace PortfolioApp.Web.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User
            CreateMap<User, UserListDto>(); // Kaynak -->  Hedef
            CreateMap<UserListDto, User>();
            #endregion

            #region Certification
            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();
            CreateMap<Certification, CertificationGetDto>();
            CreateMap<CertificationGetDto, Certification>();
            CreateMap<Certification, CertificationAddDto>().ReverseMap();
            CreateMap<Certification, CertificationUpdateDto>().ReverseMap();
            #endregion

            #region Education
            CreateMap<Education, EducationListDto>();
            CreateMap<EducationListDto, Education>();
            CreateMap<Education, EducationAddDto>().ReverseMap();
            CreateMap<Education, EducationUpdateDto>().ReverseMap();
            #endregion

            #region Interest
            CreateMap<Interest, InterestListDto>();
            CreateMap<InterestListDto, Interest>();
            CreateMap<Interest, InterestAddDto>().ReverseMap();
            CreateMap<Interest, InterestUpdateDto>().ReverseMap();
            #endregion

            #region Skill
            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();
            CreateMap<Skill, SkillGetCategoryListDto>();
            CreateMap<SkillGetCategoryListDto, Skill>();
            CreateMap<Skill, SkillAddDto>().ReverseMap();
            CreateMap<Skill, SkillUpdateDto>().ReverseMap();
            #endregion

            #region SocialMedia
            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>().ReverseMap();
            #endregion
        }
    }
}
