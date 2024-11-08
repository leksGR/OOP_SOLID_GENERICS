Employee employee = new Employee("Иван", "Официант",50000);
SalaryCaculator salaryCaculator = new SalaryCaculator();
Console.WriteLine($"{employee.Position} {employee.Name}, учитывая премию и налог, получил за прошлый месяц {salaryCaculator.OperationSalary(employee,15000,5000)} рублей.");
public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public double BaseSalary { get; set; }
    public Employee(string name, string position, double baseSalary)
    {
        Name = name;
        Position = position;
        BaseSalary = baseSalary;
    }
}

public class SalaryCaculator 
{
    private double FinalSalary;
    public double OperationSalary(Employee employee, double bonus, double tax)
    {
        FinalSalary = employee.BaseSalary + bonus - tax;
        return FinalSalary;
    }
}
