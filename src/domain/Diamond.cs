namespace Diamonds.Domain;
public class Diamond
{
    private readonly List<DiamondLine> _lines;

    public Diamond(List<DiamondLine> lines)
    {
        _lines = lines;
    }

    public string Print() 
    {
        var renderedLines = _lines.Select(x => x.ToString().TrimEnd());
        renderedLines = renderedLines.Concat(renderedLines.Reverse().Skip(1)).ToList();
        return string.Join("\n", renderedLines) + "\n";
    }
    

}
