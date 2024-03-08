using business_logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDto>> GetAll();
        Task<IEnumerable<ReviewDto>> Get(IEnumerable<int> ids);
        Task<ReviewDto>? Get(int id);
        IEnumerable<EditionDto> GetAllEditions();
        void Create(CreateReviewModel review);
        void Edit(ReviewDto review);
        void Delete(int id);
    }
}
