namespace PrototypePattern.Models;

/// <summary>
/// Сотрудник компании
/// </summary>
/// <param name="department">Отдел, где работает</param>
/// <param name="name"></param>
/// <param name="surname"></param>
public class Employee(string department, string name, Company company) : Person(name, department,company), IMyCloneable<Employee>, ICloneable
{


    public Employee Copy()
    {
        return new Employee(Department, Name, Company.Copy());
    }

    public object Clone()
    {
        return new Employee(Department, Name, (Company)Company.Clone());
    }
}