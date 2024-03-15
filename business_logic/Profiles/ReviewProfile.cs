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
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>()
                .ForMember(x => x.Edition, opt => opt.Ignore());

            CreateMap<Review, ReviewDto>();

            CreateMap<CreateReviewModel, Review>();

            CreateMap<Review, CreateReviewModel>();

            CreateMap<Edition, EditionDto>().ReverseMap();
        }
    }
}