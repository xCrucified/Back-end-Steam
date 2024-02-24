using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Entities
{
    public class User : IdentityUser
    {
        public string Summary { get; set; }
        public DateTime RegisterDate { get; set; }
        public string AvatarUrl { get; set; }
        public int Level { get; set; } = 0;
        public int Games { get; set; } = 0;

        public int CountryId { get; set; } 

        public Country? Country { get; set; }
    }
}
