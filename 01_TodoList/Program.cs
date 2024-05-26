
var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        default:
            break;
    }
}

Console.WriteLine("Press any key to close .");
Console.ReadKey();

void RemoveTodo()
{
    if(todos.Count == 0)
    {
        ShowNoTodosMessage();
    }
    int index;
    do
    {
        Console.WriteLine("Select the index of TODO you want to remove:");
        SeeAllTodos();
    } while (!TryReadIndex(out index));
    RemoveTodoAtIndex(index - 1);
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("Todo removed : "+todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if(userInput == "")
    {
        index = 0;
        Console.WriteLine("Select index cannot be empty");
        return false;
    }

    if(int.TryParse(userInput,out index) && index >=1 && index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        description = Console.ReadLine() ?? "";
    } while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if(description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }
    return true;
}



void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}

