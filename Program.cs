namespace PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee("Sales","test", "testovich");
        var employeeClone = (Employee)employee.Clone();
        var employeeCopy = (Employee)employee.Copy();
        
        Console.WriteLine($"hashcode initial object ={employee.GetHashCode()}");
        Console.WriteLine($"hashcode clone object ={employeeClone.GetHashCode()}");
        Console.WriteLine($"hashcode copying object ={employeeCopy.GetHashCode()}");
        
        var manager = new Manager(4,"Sales","test", "testovich");
        var managerClone = (Manager)manager.Clone();
        var managerCopy = (Manager)manager.Copy();
        
        Console.WriteLine($"hashcode initial object ={manager.GetHashCode()}");
        Console.WriteLine($"hashcode clone object ={managerClone.GetHashCode()}");
        Console.WriteLine($"hashcode copying object ={managerCopy.GetHashCode()}");
    }
    
    /// <summary>
    /// Общий класс
    /// </summary>
    /// <param name="name">Имя человека</param>
    /// <param name="surname">Фамилия</param>
    public class Person(string name, string surname)
    {
        public string Name = name;
        public string Surname = surname;
        
    }

    /// <summary>
    /// Сотрудник компании
    /// </summary>
    /// <param name="department">Отдел, где работает</param>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    public class Employee(string department, string name, string surname) : Person(name, surname), IMyCloneable, ICloneable
    {
        public string Department = department;

        public object Copy()
        {
            return new Employee(Department, Name, Surname);
        }

        public object Clone()
        {
            return new Employee(Department, Name, Surname);
        }
    }
    
    /// <summary>
    /// Менеджер, управляющий сотрудниками
    /// </summary>
    /// <param name="amountMeetings">количество встреч</param>
    /// <param name="department"></param>
    /// <param name="name"></param>
    /// <param name="surname"></param>

    public class Manager(int amountMeetings,string department, string name, string surname) : Employee(department, name, surname), IMyCloneable, ICloneable
    {
        public int AmountMeetings = amountMeetings;

        public object Copy()
        {
            return new Manager(AmountMeetings, Department, Name, Surname);
        }
        
        public object Clone()
        {
            return new Manager(AmountMeetings, Department, Name, Surname);
        }
    }
}