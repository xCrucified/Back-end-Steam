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
    internal static class EditionSpecs
    {
        internal class ById : Specification<Edition>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Category);
            }
        }
        internal class All : Specification<Edition>
        {
            public All()
            {
                Query.Include(x => x.Category);
            }
        }
        internal class ByIds : Specification<Edition>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Category);
            }
        }
    }
}
