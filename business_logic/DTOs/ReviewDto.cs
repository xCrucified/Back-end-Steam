using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string? Comment { get; set; }

        public int EditionId { get; set; }
        public int UserId { get; set; }
    }
}
