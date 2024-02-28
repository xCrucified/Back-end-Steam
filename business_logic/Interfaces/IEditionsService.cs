using business_logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IEditionsService
    {
        IEnumerable<EditionDto> GetAll();
        IEnumerable<EditionDto> Get(IEnumerable<int> ids);
        EditionDto? Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        void Create(CreateEditionModel product);
        void Edit(EditionDto product);
        void Delete(int id);
    }
}
