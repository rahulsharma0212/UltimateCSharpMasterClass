
namespace _2_NamesBeforeRefactorToSRP.DataAccess;
public class StringTextualRepository
{
    private static readonly string seprator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(seprator).ToList();
    }

    public void Write(string filePath, List<string> names)
    {
        File.WriteAllText(filePath, string.Join(seprator, names));
    }
}

