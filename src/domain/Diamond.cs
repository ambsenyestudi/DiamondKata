namespace Diamonds.Domain;
public class Diamond
{
    private const string LINE_BREAK = "\n";
    private readonly List<DiamondLine> _lines;

    public Diamond(List<DiamondLine> lines)
    {
        _lines = lines;
    }

    public string Print() 
    {
        var renderedLines = _lines.Select(x => x.ToString().TrimEnd());
        renderedLines = renderedLines.Concat(renderedLines.Reverse().Skip(1)).ToList();
        return string.Join(LINE_BREAK, renderedLines) + LINE_BREAK;
    }
    

}
