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
    internal static class CategorySpec
    {
        internal class ById : Specification<Category>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id);
            }
        }
        internal class All : Specification<Category>
        {
            public All()
            {
                Query.Include(x => x.Id);
            }
        }
        internal class ByIds : Specification<Category>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id));
            }
        }
    }
}
