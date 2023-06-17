var list = new List<Person>();
for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine($"Persone {i+1}");
    var person=new Person()
    {
   name =Console.ReadLine(),
   surname =Console.ReadLine(),
   age = int.Parse(Console.ReadLine()),
    };
    list.Add(person);
}
foreach (var person1 in list)
{
    System.Console.WriteLine($"Hello! My name is {person1.name} {person1.surname}");
}

public class Person
{
    public string name; 
    public string surname;
    public int age; 

 public string GetInfo(){
    return $"{name} {surname} - {age}";
}
}
