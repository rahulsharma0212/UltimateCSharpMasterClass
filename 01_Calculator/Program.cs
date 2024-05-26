Console.WriteLine("Hello");

Console.WriteLine("Input the first number");
var firstAsText = Console.ReadLine();
var num1= int.Parse(firstAsText);

Console.WriteLine("Input the second number");
var secondAsText = Console.ReadLine();
var num2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if (EqualsCaseInsensitive(choice, "A"))
{
    PrintFinalEquation(num1, num2, num1 + num2, "+");
}else if (EqualsCaseInsensitive(choice, "S"))
{
    PrintFinalEquation(num1, num2, num1 - num2, "-");
}else if (EqualsCaseInsensitive(choice, "M"))
{
    PrintFinalEquation(num1, num2, num1 * num2, "*");
}
else
{
    Console.WriteLine("Invalid Choice");
}
Console.WriteLine("Press any key to close .. ");
Console.ReadKey();

void PrintFinalEquation(int num1,int num2,int result,string @operator) {
    Console.WriteLine($"{num1} {@operator} {num2} = {result}");
}

bool EqualsCaseInsensitive(string left,string right){ 
    return left.ToLower() == right.ToLower();
}
