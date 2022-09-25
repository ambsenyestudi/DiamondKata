namespace Diamonds.Domain;

public class LineService
{
    private readonly MirroringService _mirroringService;
    private const string ALPHABETH_START = "A";
    private const string SPACE = " ";
    private const string LINE_BREAK = "\n";
    public LineService(MirroringService mirroringService)
    {
        _mirroringService = mirroringService;
    }


    public string CreateLine(string letter, string upTo)
    {
        var delta = FigureDelta(ALPHABETH_START, upTo);
        var result = string.Empty;
        for (int i = 0; i < delta + 1; i++)
        {
            string newPosition = ToCharacter(letter, upTo, i);
            result += newPosition;

        }
        return result + LINE_BREAK;
    }

    private static string ToCharacter(string letter, string upTo, int index) =>
        FigureDelta(letter, upTo) == index
                        ? letter
                        : SPACE;

    private static int FigureDelta(string start, string end) =>
        FigureDelta(start[0], end[0]);

    private static int FigureDelta(char start, char end) =>
        end - start;
}
