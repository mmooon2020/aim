using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ShopsCategories
    {
        public int ShopID { get; set; }
        public Shops Shops { get; set; }
        public int CategoryID { get; set; }
        public Categories Categories { get; set; }
    }
}
