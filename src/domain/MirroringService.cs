namespace Diamonds.Domain;

public class MirroringService
{
    public string Mirror(string line) =>
        line + Reverse(line);

    public string Mirror(List<string> lines)
    {
        throw new NotImplementedException();
    }

    private string Reverse(string line)
    {
        var reversedChars = line.Reverse().Skip(1).ToArray();
        return new string(reversedChars);
    }

}
