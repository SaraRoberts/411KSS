using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public String Location { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public String Prerequisite { get; set; }
    }
}
