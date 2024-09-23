using PrototypePattern.Models;

namespace PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        var company = new Company("TestName", "testINN");
        var employee = new Employee("Sales","Volodya",  company);
        var employeeClone = (Employee)employee.Clone();
        var employeeCopy = employee.Copy();
        
        Console.WriteLine($"hashcode initial object ={employee.GetHashCode()}");
        Console.WriteLine($"hashcode clone object ={employeeClone.GetHashCode()}");
        Console.WriteLine($"hashcode copying object ={employeeCopy.GetHashCode()}");
        
        var manager = new Manager(4,5,"test","Yura", company);
        var managerClone = (Manager)manager.Clone();
        var managerCopy = manager.Copy();
        
        Console.WriteLine($"hashcode initial object ={manager.GetHashCode()}");
        Console.WriteLine($"hashcode clone object ={managerClone.GetHashCode()}");
        Console.WriteLine($"hashcode copying object ={managerCopy.GetHashCode()}");
    }
}