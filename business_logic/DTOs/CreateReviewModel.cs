using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class CreateReviewModel
    {
        public string? Description { get; set; }
        public Boolean? Rate { get; set; }
        public string? Comment { get; set; }
        public IFormFile? Attachment { get; set; }

        public int EditionId { get; set; }
        public int UserId { get; set; }
    }
}
