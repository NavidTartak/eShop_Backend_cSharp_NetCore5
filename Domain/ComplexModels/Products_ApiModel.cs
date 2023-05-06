using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ComplexModels
{
    public class Products_ApiModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public bool IncredibleOffers { get; set; }
        public bool DailySuggest { get; set; }
        public string IndexImageUrl { get; set; }
        public virtual List<Product_Images_ApiModel> Images { get; set; }
       
    }
}
