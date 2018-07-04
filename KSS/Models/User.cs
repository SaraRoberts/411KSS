using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public int CellNumber { get; set; }
        public int HomeNumber { get; set; }
    }
}
