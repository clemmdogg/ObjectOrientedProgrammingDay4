using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities;

internal class Person : IDepartment
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string DepartmentName { get; set; }
    public Person(string firstName, string lastName) {  FirstName = firstName; LastName = lastName;}
    public void SetDepartment(string value)
    {
        DepartmentName = value;
    }
}
