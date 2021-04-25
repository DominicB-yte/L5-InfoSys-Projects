using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFirstCodeCoursework
{
    public class Students
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Schools schools { get; set; }
    }
}
