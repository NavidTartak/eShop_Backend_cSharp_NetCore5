using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Products
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Index_Image_Url { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Price_With_Discount { get; set; }
        public int Stock { get; set; }
        public int Category_Id { get; set; }
        public bool Incredible_Offers { get; set; }
        public bool Daily_Suggest { get; set; }
    }
}
