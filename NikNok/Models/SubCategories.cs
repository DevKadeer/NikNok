using System;
using System.Collections.Generic;

namespace NikNok.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }

        public Categories Category { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
