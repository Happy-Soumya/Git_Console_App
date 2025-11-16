using Git_Console_App.Models;

Employee employee = new ();

employee.Id = 1;
employee.Name = "Soumya Ranjan Ojha";
employee.Salary = 89000;
//Comment Added

Console.WriteLine("Name is "+employee.Name + " having ID : " + employee.Id + " of salary "+ employee.Salary);

Customer customer = new ();
customer.Id = 1;
customer.Name = "Happy";

Console.WriteLine(customer.Name + " having ID : " + customer.Id);


Student student = new Student();

Console.ReadLine();