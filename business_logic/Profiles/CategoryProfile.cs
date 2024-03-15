using AutoMapper;
using business_logic.DTOs;
using data_access.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryDto>();

            CreateMap<CreateCategoryModel, Category>();

            CreateMap<Category, CreateCategoryModel>();
        }
    }
}
