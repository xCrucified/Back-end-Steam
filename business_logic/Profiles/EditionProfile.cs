using AutoMapper;
using business_logic.DTOs;
using business_logic.Interfaces;
using data_access.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Profiles
{
    public class EditionProfile : Profile
    {
        public EditionProfile(IFileService fileService)
        {
            CreateMap<EditionDto, Edition>()
                .ForMember(x => x.Category, opt => opt.Ignore());
            CreateMap<Edition, EditionDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<CreateEditionModel, Edition>()
                .ForMember(x => x.ImgUrl, opt => opt.MapFrom(src => fileService.SaveProductImage(src.Image).Result));

            CreateMap<RegisterModel, User>()
                .ForMember(x => x.UserName, opts => opts.MapFrom(s => s.Email));
        }
    }
}
