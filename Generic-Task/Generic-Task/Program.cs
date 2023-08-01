using Generic_Task;

DataList<Employee> employees = new DataList<Employee>();

employees.Add(new Employee { Id = 1, Name = "Ismayil" });
employees.Add(new Employee { Id = 2, Name = "Xeyyam" });

var result=employees.Delete(1);
Console.WriteLine(result.Name);