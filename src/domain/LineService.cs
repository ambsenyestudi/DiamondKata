namespace Diamonds.Domain;

public class LineService
{
    private readonly MirroringService _mirroringService;
    private const string ALPHABETH_START = "A";
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

            var newPosition = FigureDelta(letter, upTo) == i
                ? letter
                : " ";
            result += newPosition;

        }
        return result;
    }

    private static int FigureDelta(string start, string end) =>
        FigureDelta(start[0], end[0]);

    private static int FigureDelta(char start, char end) =>
        end - start;
}
