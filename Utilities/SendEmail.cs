using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities;

internal class SendEmail
{
    public string Send(IDepartment person)
    {
        string? message = null;
        if(person.GetType() == typeof(Teacher))
        {
            // Send email to teacher
            return "Email er sendt til læren";
        }
        else if(person.GetType() == typeof(Student))
        {
            // Send email to Itslearning
            return "Besked er sendt til itslearning";
        }
        return message;
    }
}
