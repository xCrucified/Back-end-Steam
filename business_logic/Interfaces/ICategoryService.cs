using business_logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface ICategoryService 
    {
        Task<IEnumerable<CategoryDto>> GetAll();
        Task<IEnumerable<CategoryDto>> Get(IEnumerable<int> ids);
        Task<CategoryDto>? Get(int id);
        IEnumerable<CategoryDto> GetAllEditions();
        void Create(CreateCategoryModel category);
        void Edit(CategoryDto category);
        void Delete(int id);
    }
}
