using AutoMapper;
using business_logic.DTOs;
using business_logic.Interfaces;
using business_logic.Specifications;
using data_access.data.Entities;
using data_access.Repositories;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Services
{
    public class ReviewsService : IReviewService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Review> reviewR;
        private readonly IRepository<User> userR;
        private readonly IRepository<Edition> editionR;

        public ReviewsService(IMapper mapper,
                              IRepository<Review> reviewR,
                              IRepository<User> userR,
                              IRepository<Edition> editionR)
        {
            this.mapper = mapper;
            this.reviewR = reviewR;
            this.userR = userR;
            this.editionR = editionR;
        }
        public void Create(CreateReviewModel review)
        {
            reviewR.Insert(mapper.Map<Review>(review));
            reviewR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var product = reviewR.GetByID(id);

            if (product == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            reviewR.Delete(product);
            reviewR.Save();
        }

        public void Edit(ReviewDto review)
        {
            reviewR.Update(mapper.Map<Review>(review));
            reviewR.Save();
        }


        public async Task<ReviewDto>? Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await reviewR.GetItemBySpec(new ReviewSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<ReviewDto>(item);

            return dto;
        }
        public async Task<IEnumerable<ReviewDto>> Get(IEnumerable<int> ids) => mapper.Map<List<ReviewDto>>(await reviewR.GetListBySpec(new ReviewSpecs.ByIds(ids)));
        public async Task<IEnumerable<ReviewDto>> GetAll() => mapper.Map<List<ReviewDto>>(await reviewR.GetListBySpec(new ReviewSpecs.All()));
        public IEnumerable<EditionDto> GetAllEditions() => mapper.Map<List<EditionDto>>(editionR.GetAll());
    }
}
