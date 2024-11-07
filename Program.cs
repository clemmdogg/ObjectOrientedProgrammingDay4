// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgrammingDay4.Utilities;
Console.WriteLine("Hello, World!");
Teacher t = new("Niels", "Olesen");
Student s = new("Simon", "Heilbuth");
t.SetDepartment("CIT");

SendEmail se = new();
string messageTeacher = se.Send(t);
string messageStudent = se.Send(s);

Console.WriteLine(messageTeacher);
Console.WriteLine(messageStudent);

Console.WriteLine($"This department is: {t.DepartmentName}");
Console.WriteLine(t.GetInterfaceInfo());
Console.WriteLine($"This department is: {s.DepartmentName}");