
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        Name = name;
        Age = age;

    }
} 
class Program
{ 
    static void Main(string[] args)
    {
        string persoName = "giorgi";
        int personAge = 56;
        Console.WriteLine($"Name: {persoName}, Age: {personAge}");
    }

    
}