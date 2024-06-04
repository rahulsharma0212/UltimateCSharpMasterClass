using Polymorphism.NumberSumCalculators;
using System.Text.Json;

var person = new Person()
{
    FirstName="Rahul",
    LastName="Sharma",
    YearOfBirth=1999
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("-------JSON----------");
Console.WriteLine(asJson);
Console.WriteLine("-------JSON----------");

var personJson = "{\"FirstName\":\"Rahul\",\"LastName\":\"Sharma\",\"YearOfBirth\":1999}";
var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = false;

NumberSumCalculators calculator =
shallAddPositiveOnly ?
    new PositiveNumberSumCalculator() :
    new NumberSumCalculators();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is: " + sum);

Console.ReadKey();

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int YearOfBirth {  get; set; }
}