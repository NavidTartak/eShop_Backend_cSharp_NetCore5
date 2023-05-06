using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Header_Banner
    {
        public int Id { get; set; }
        public string Image_Path { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Main { get; set; }
        public string Url { get; set; }
    }
}
