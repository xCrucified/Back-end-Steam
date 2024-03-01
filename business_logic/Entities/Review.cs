using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string? Comment { get; set; }

        public int EditionId { get; set; }
        public int UserId { get; set; }

        public User? User { get; set; }
        public Edition Edition { get; set; }
    }
}
