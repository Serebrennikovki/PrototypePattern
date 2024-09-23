namespace PrototypePattern.Models;

/// <summary>
/// Общий класс
/// </summary>
/// <param name="name">Имя человека</param>
/// <param name="surname">Фамилия</param>
public class Person(string name, string department, Company company)
{
    public string Name = name;
    public string Department = department;

    public Company Company = company;

}