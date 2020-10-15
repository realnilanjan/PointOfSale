using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string UserRole { get; set; }
        public string Contact { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }
    }
}
