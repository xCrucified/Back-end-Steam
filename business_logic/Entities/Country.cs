﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Entities
{
    public enum Countries
    {
        Ukraine = 1,
        Brazil,
        Canada,
        Germany,
        India,
        Japan,
        Mexico,
        SouthAfrica,
        UnitedKingdom,
        UnitedStates
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
