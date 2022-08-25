Console.WriteLine("Hello, BGU!");

Percent p = new Percent();
Console.WriteLine(p.Value);
p.Value = 400;
Console.WriteLine(p.Value);

Person person = new Person("Marcus","101010101-11010");
Console.WriteLine(person.Name);
Console.WriteLine(person.PersNum);

person.Name = "Kalle";
Console.WriteLine(person.Name);
Console.WriteLine(person.PersNum);

Person person1 = new Person("303030-3030");
person1.Name = "Johan";
Console.WriteLine(person1.Name);
Console.WriteLine(person1.PersNum);

public class Person
{
    public string Name { get; set; }
    public string PersNum { get; } // skrivskyddad

    // Constructor
    public Person(string name, string persNum)
    {
        Name = name;
        PersNum = persNum;
    }
    public Person (string persNum)
    {
        PersNum = persNum;
    }
}

class Percent
{
    int percent = 0;
    public int Value
    {
        get { return percent; }
        set {
            if (value > 100) percent = 100;
            else if (value < 0) percent = 0;
            else
                percent = value;
            }
    }
}