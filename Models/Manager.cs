namespace PrototypePattern.Models;

/// <summary>
/// Менеджер, управляющий сотрудниками
/// </summary>
/// <param name="amountMeetings">количество встреч</param>
/// <param name="department"></param>
/// <param name="name"></param>
/// <param name="surname"></param>

public class Manager(int amountMeetings, int amountEmployees,string department, string name,Company company) : Person(name, department, company), IMyCloneable<Manager>, ICloneable
{
    public int AmountMeetings = amountMeetings;
    public int AmountEmploees = amountEmployees;

    public Manager Copy()
    {
        return new Manager(AmountMeetings, AmountEmploees, Department, Name, Company.Copy());
    }
        
    public object Clone()
    {
        return new Manager(AmountMeetings, AmountEmploees, Department, Name, (Company)Company.Clone());
    }
}