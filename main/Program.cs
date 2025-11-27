// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Text");
Random rnd = new Random();
int firstNumber = rnd.Next(1,100);
int secondNumber = rnd.Next(1,100);
Console.WriteLine($"{firstNumber} + {secondNumber}");
string input = Console.ReadLine();
if (firstNumber + secondNumber ==  Int32.Parse(input)){
    Console.WriteLine("Right!");
}
else{
    Console.WriteLine($" Wrong! {firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
}
input = Console.ReadLine();
Console.WriteLine(input);
var userid = 0;
var Bog = new Bogus.Faker<User>()
    .RuleFor( u => u.Id, f => userid++)
    .RuleFor(u => u.Name, f => Guid.NewGuid().ToString());

List<User> users = Bog.Generate(20);
foreach (User user in users)
{
    Console.WriteLine($"{user.Id}\t{user.Name}");
}

class User()
{
    public int Id{get;set;}
    public string? Name{get;set;}

    public User(string name):this()
    {
        Name = name;
    }    
}