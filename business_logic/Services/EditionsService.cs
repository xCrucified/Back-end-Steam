using AutoMapper;
using business_logic.DTOs;
using business_logic.Interfaces;
using BusinessLogic;
using data_access.data.Entities;
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
                                IRepository<Edition> productsR,
                                IRepository<Category> categoriesR)
        {
            this.mapper = mapper;
            this.editionR = productsR;
            this.categoriesR = categoriesR;
        }

        public void Create(CreateEditionModel product)
        {
            editionR.Insert(mapper.Map<Edition>(product));
            editionR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpExceptions(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            // delete product by id
            var product = editionR.GetByID(id);

            if (product == null) throw new HttpExceptions(Errors.ProductNotFound, HttpStatusCode.NotFound);

            editionR.Delete(product);
            editionR.Save();
        }

        public void Edit(EditionDto edition)
        {
            editionR.Update(mapper.Map<Edition>(edition));
            editionR.Save();
        }

        public EditionDto? Get(int id)
        {
            if (id < 0) throw new HttpExceptions(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = editionR.GetByID(id);
            if (item == null) throw new HttpExceptions(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<EditionDto>(item);

            return dto;
        }

        public IEnumerable<EditionDto> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<EditionDto>>(editionR.Get(x => ids.Contains(x.Id), includeProperties: "Category"));
        }

        public IEnumerable<EditionDto> GetAll()
        {
            return mapper.Map<List<EditionDto>>(editionR.GetAll());
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(categoriesR.GetAll());
        }
    }
}
