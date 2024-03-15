using AutoMapper;
using business_logic.DTOs;
using business_logic.Interfaces;
using business_logic.Specifications;
using data_access.data.Entities;
using data_access.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Category> categoryR;

        public CategoryService(IMapper mapper, IRepository<Category> categoryR)
        {
            this.mapper = mapper;
            this.categoryR = categoryR;
        }
        public void Create(CreateCategoryModel category)
        {
            categoryR.Insert(mapper.Map<Category>(category));
            categoryR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var product = categoryR.GetByID(id);

            if (product == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            categoryR.Delete(product);
            categoryR.Save();
        }

        public void Edit(CategoryDto category)
        {
            categoryR.Update(mapper.Map<Category>(category));
            categoryR.Save();
        }


        public async Task<CategoryDto>? Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await categoryR.GetItemBySpec(new CategorySpec.ById(id));
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<CategoryDto>(item);

            return dto;
        }
        public async Task<IEnumerable<CategoryDto>> Get(IEnumerable<int> ids) => mapper.Map<List<CategoryDto>>(await categoryR.GetListBySpec(new CategorySpec.ByIds(ids)));
        public async Task<IEnumerable<CategoryDto>> GetAll() => mapper.Map<List<CategoryDto>>(await categoryR.GetListBySpec(new CategorySpec.All()));
        public IEnumerable<CategoryDto> GetAllEditions() => mapper.Map<List<CategoryDto>>(categoryR.GetAll());
    }
}
