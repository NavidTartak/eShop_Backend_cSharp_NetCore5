using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Activation_Sms_Code { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Expired { get; set; }
        public bool Is_Lock { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
