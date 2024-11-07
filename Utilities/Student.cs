using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities;

internal class Student : Person, IDepartment
{
    public Student(string firstName, String lastName) : base(firstName, lastName)
    {
    }
}
