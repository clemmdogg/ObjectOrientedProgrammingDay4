using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities;

internal class Teacher : Person, IDepartment
{
    public Teacher(string firstName, String lastName) : base(firstName, lastName)
    {
    }
    public string GetInterfaceInfo()
    {
        IDepartment myInterface = this;
        return  myInterface.GetInfo();
    }
}
