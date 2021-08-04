using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Categories
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategories> SubCategories { get; set; }
        public ICollection<ShopsCategories> ShopsCategories { get; set; }

    }
}
