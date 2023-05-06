using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ComplexModels
{
    public class Product_Images_ApiModel
    {
        public long Id { get; set; }
        public string Original { get; set; }
        public string Thumbnail { get; set; }
    }
}
