// ###################
// Variables
// ###################
//Console.WriteLine(name); // will not compile , because it is not yet declared and initialized


string name = "Rahul"; //  variable initialization at declaration
int number; // variable declaration
number = 10; // variable initialization
number = 15; // assigning new value to a variable 
Console.WriteLine(number); //  15 will printed on console
//int lastName = "sharma"; // wil not compile because string will not assign to int type



// ###################
// Naming Variables
// ###################
//string class = "First";// will not compile , class is reserved keyword
string @class = "First"; // we can use reserve keyword as variable if we precede it with @ symbol
int _numner = 10;
int another_number = 15;// valid name , but not in line with c# convention
int oneMoreNumber = 20;// c# uses lower camel case
//int 1number=1;// will not compile , digit cannot be the first character
string name1 = "Temp"; // digit will be fine if it is not the first character
int age, Age;// they are two different  variables , c# is case-sensitive
//int number-one=1; // will not compile we can't use '-'



// ###################
// Operators
// ###################
int sum = 5 + 10;
int resultWithouParanthesis = 5 + 2 * 3;
int resultWithParanthesis = 5 + (2 * 3);
var stringAndInt = "abc" + 5;



// ###################
// Implicity typed variables
// ###################
string word1 = "text"; // explicitly typed variable
var word2 = "test";// implicitly typed variable
//var invalidVariable; // will not complile, implicitly typed variable mus be initialized



// ###################
// Comments
// ###################

// single line comment
/*
this is 
a multiline 
comment
*/



// ###################
// Boolean type
// Logical negation,equality,comparison and modulo operators
// ###################
Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();
bool isUserInputAbc = userInput == "ABC";
bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC");
var isLargerThan5 = number > 5;
var isSmallerThan10 = number <= 10;
var isLargerThanOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;
var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = number % 2 == 0;
var isOdd = number % 2 == 1;

var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 = number == 20 || number > 60 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 = number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 0; //  the second condition will not be evaluated due to short-circuting
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0;// the second condition will not be evaluated due to short-circuting



//###################
//if/else statements
//###################
if (userInput.Length <= 3)
{
    Console.WriteLine("Short Answer");
}
else if (userInput.Length < 10)
{
    Console.WriteLine("Medium Answer");
}
else
{
    Console.WriteLine("Long Answer");
}



//###################
//Scopes
//###################
if (userInput.Length == 0)
{
    Console.WriteLine("Empty choice");
    var word = "ABC";
    int someNumber = 5;
    if (word.Length > 0)
    {
        Console.WriteLine(someNumber);// someNumber is available here
    }
}
else
{
    int someNumber = 5;// named the same as the variable inside the "if". It is fine ,because those variable live in different scopes
}
Console.WriteLine("Your choice is :: " + userInput);
//Console.WriteLine(someNumber); // will not compile, someNumber is not available here



//###################
//Methods - part 1 - void methods
//###################
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option :: " + selectedOption);
}



//###################
//Methods - part 2 - non-void methods
//###################
//See 1_TodoList project for more about methods
int Add(int a, int b)
{
    return a + b;
}
bool IsLong(string input)
{
    return input.Length > 10;
}



//###################
//Parsing a string to an int
//###################
string numberAsText = "1230";
int parsedInt = int.Parse(numberAsText);



//###################
//String interpolation
//###################
int a = 4, b = 2, c = 10;
Console.WriteLine("First is :: " + a + ", second is :: " + b + ", third is :: " + c);
Console.WriteLine($"First is :: {a}, second is :: {b}, third is :: {c}");
Console.WriteLine($"sum is :: {a + b + c}, second is :: {b}, third is :: {c}");



//###################
//Switch statement
//###################
//See 1_TodoList project for more about switch
//###################
//Char
//###################
char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'a';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}



//###################
//While loop
//###################
var numberWhileLoop = 0;
Console.WriteLine("The While loop started");
while (numberWhileLoop < 10)
{
    numberWhileLoop += 1;
    Console.WriteLine($"Number is {numberWhileLoop}");
}
Console.WriteLine("The While loop finished");

var someText = "Hello";
while (someText.Length < 10)
{
    someText += 'a';
    Console.WriteLine(someText);
}
Console.WriteLine("the loop finished");



//###################
//Do-while loop
//###################
do
{
    Console.WriteLine("Enter input longer than 10 letters");
    userInput = Console.ReadLine();
} while (userInput.Length <= 10);



//###################
//For loop
//###################
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"loop run {i}");
}
for (int i = 10; i > 5; i--)
{
    Console.WriteLine($"loop run {i}");
}



//###################
//Break and continue
//###################
for (int i = 0; i < 100; i++)
{
    if (i > 25) break;
    Console.WriteLine($"break will trigger in {25 - i}");
}

int userNumber;
do
{
    Console.WriteLine("Enter a number larger than 10.");
    var input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }
    bool isParasableToInt = input.All(char.IsDigit);
    if (!isParasableToInt) { userNumber = 0; continue; };
    userNumber = int.Parse(input);
} while (userNumber <= 10);

Console.WriteLine("non-Multiple of 3 less than 20");
for (int i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);

}



//###################
//Nested loops
//###################
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($" i => {i}; j=> {j}");
    }
}



//###################
//Arrays
//###################
var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
numbers[1] = 10;
var firstFromEnd1 = numbers[numbers.Length - 1];
var firstFromEnd2 = numbers[^1];
var secondFromEnd1 = numbers[numbers.Length - 2];
var secondFromEnd2 = numbers[^2];

int sumOfNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sumOfNumbers++;
}



//###################
//Multi-dimensional arrays
//###################
char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var letters2 = new char[,]
{
    {'A','B','C' },
    {'D','E','F' }
};

var height = letters.GetLength(0);
var width = letters.GetLength(1);

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"i is {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"j is {j}");
        Console.WriteLine($"element is {letters[i, j]}");

    }
}



//###################
//Foreach loop
//###################
var words = new string[] { "one","two","three"};
foreach(var word in words)
{
    Console.WriteLine(word);
}



//###################
//Lists
//###################
var someWords = new List<string>()
{
    "one","two"
};
someWords.Add("three");
someWords.AddRange(new[] { "four","five"});
someWords.Remove("three");
someWords.RemoveAt(0);
var indexOfFive = someWords.IndexOf("five");
bool containsOne = someWords.Contains("one");
someWords.Clear();



//###################
//Out parameter
//###################
var variousNumbers = new int[] { 10, -8, 2, 12, -17 };
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(variousNumbers, out countOfNonPositiveNumbers);

List<int> GetOnlyPositive(int[] variousNumbers, out  int countOfNonPositiveNumbers)
{
    List<int> positiveNums = new List<int>();
    countOfNonPositiveNumbers = 0;
    foreach (var num in variousNumbers)
    {
        if(num >0) positiveNums.Add(num);
        else
        {
            countOfNonPositiveNumbers++;
        }
    }
    return positiveNums;
}



//###################
//Out parameter
//###################
bool isParsed = int.TryParse(userInput, out int userInputParsedToInt);
if (isParsed)
{
    Console.WriteLine("Parsed successfully, the result is :: "+userInputParsedToInt);
}
else
{
    Console.WriteLine($"Could not parse '{userInput}' to int");
}
Console.WriteLine("Press any key to close");


Console.ReadLine();