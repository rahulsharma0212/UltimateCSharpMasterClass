namespace Polymorphism.Extensions;

public static class StringExtension
{
    public static int CountLines(this string input) => 
        input.Split(Environment.NewLine).Length;
}
