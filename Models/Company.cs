namespace PrototypePattern.Models;

public class Company(string name, string inn) :  IMyCloneable<Company>, ICloneable
{
    public string Name = name;
    public string INN = inn;

    public Company Copy()
    {
        return new Company(Name, INN);
    }

    public object Clone()
    {
        return new Company(Name, INN);
    }
}