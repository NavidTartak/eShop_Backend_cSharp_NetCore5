using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ComplexModels
{
    public class Products_Categories_ApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products_ApiModel> Products { get; set; }
        public Products_Categories_ApiModel()
        {
            this.Products = new List<Products_ApiModel>();
        }
    }
}
