using Git_Console_App.Models;

Employee employee = new Employee();

employee.Id = 1;
employee.Name = "Soumya";

Console.WriteLine(employee.Name + " having ID : " + employee.Id);
Console.ReadLine();