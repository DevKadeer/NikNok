using System;
using System.Collections.Generic;

namespace NikNok.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public Categories Category { get; set; }
        public SubCategories SubCategory { get; set; }
    }
}
