using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product_Images
    {
        public long Id { get; set; }
        public long Product_Id { get; set; }
        public string Original { get; set; }
        public string Thumbnail { get; set; }
    }
}
