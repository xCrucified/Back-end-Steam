using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Entities
{
    public class Edition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImgUrl { get; set; }
        public int? Discount { get; set; }
        //add dlc
        public ICollection<Category>? Category { get; set; }
        public ICollection<Review>? Review { get; set; }
    }
}
