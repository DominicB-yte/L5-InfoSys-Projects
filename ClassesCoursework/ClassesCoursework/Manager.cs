using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCoursework
{
    class Manager : Employee
    {
        public string departmentName { get; set; }
        public List<Employee> directReports = new List<Employee>();

        //Return a list of the manager's direct reports
        public string getDirectReportsList()
        {
            string result = "";
            foreach (Employee emp in directReports)
            {
                result += emp.firstName + "" +
                emp.lastName + "\n";
            }
            return result;
        }
    }
}
