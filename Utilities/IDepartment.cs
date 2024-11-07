using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities;

internal interface IDepartment
{
    public string DepartmentName { get; set; }
    public void SetDepartment(string value);

    public string GetInfo()
    {
        return "Use this interface for every type that need department name!";
    }
}
