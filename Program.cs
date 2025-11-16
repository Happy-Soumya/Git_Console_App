using Git_Console_App.Models;

Employee employee = new Employee();

employee.Id = 1;
employee.Name = "Soumya";
employee.Salary = 78000;

Console.WriteLine(employee.Name + " having ID : " + employee.Id + " of salary "+ employee.Salary);

Customer customer = new Customer();
customer.Id = 1;
customer.Name = "Happy";

Console.WriteLine(customer.Name + " having ID : " + customer.Id);


Student student = new Student();

Console.ReadLine();