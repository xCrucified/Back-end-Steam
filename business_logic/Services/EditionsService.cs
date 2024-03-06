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
    public class EditionsService : IEditionsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Edition> editionR;
        private readonly IRepository<Category> categoriesR;
        //private readonly ShopDbContext context;

        public EditionsService(IMapper mapper,
                                IRepository<Edition> editionsR,
                                IRepository<Category> categoriesR)
        {
            this.mapper = mapper;
            this.editionR = editionsR;
            this.categoriesR = categoriesR;
        }

        public void Create(CreateEditionModel product)
        {
            editionR.Insert(mapper.Map<Edition>(product));
            editionR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            // delete product by id
            var product = editionR.GetByID(id);

            if (product == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            editionR.Delete(product);
            editionR.Save();
        }

        public void Edit(EditionDto edition)
        {
            editionR.Update(mapper.Map<Edition>(edition));
            editionR.Save();
        }

        public async Task<EditionDto>? Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await editionR.GetItemBySpec(new EditionSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<EditionDto>(item);

            return dto;
        }

        public async Task<IEnumerable<EditionDto>> Get(IEnumerable<int> ids) => mapper.Map<List<EditionDto>>(await editionR.GetListBySpec(new EditionSpecs.ByIds(ids)));

        public async Task<IEnumerable<EditionDto>> GetAll() => mapper.Map<List<EditionDto>>(await editionR.GetListBySpec(new EditionSpecs.All()));

        public IEnumerable<CategoryDto> GetAllCategories() => mapper.Map<List<CategoryDto>>(categoriesR.GetAll());
    }
}
