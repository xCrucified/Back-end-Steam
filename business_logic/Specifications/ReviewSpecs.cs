using Ardalis.Specification;
using data_access.data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Specifications
{
    internal static class ReviewSpecs
    {
        internal class ById : Specification<Review>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Edition);
            }
        }
        internal class All : Specification<Review>
        {
            public All()
            {
                Query.Include(x => x.Edition);
            }
        }
        internal class ByIds : Specification<Review>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Edition);
            }
        }
    }
}
