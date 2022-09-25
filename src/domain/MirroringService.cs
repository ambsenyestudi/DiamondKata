namespace Diamonds.Domain;

public class MirroringService
{
    public string Mirror(string line) =>
        line + Reverse(line);

    public string Mirror(List<string> lines)
    {
        var reversedLines = Reverse(lines);
        return string.Join("", lines) + reversedLines;
    }

    private string Reverse(List<string> lines)
    {
        var result = new List<string>(lines);
        result.Reverse();
        return string.Join("", result.Skip(1));
    }
    private string Reverse(string line)
    {
        var reversedChars = line.Reverse().Skip(1).ToArray();
        return new string(reversedChars);
    }

}
