namespace Diamonds.Domain;

public class LineService
{
    private readonly MirroringService _mirroringService;
    private const char ALPHABETH_START = 'A';
    public LineService(MirroringService mirroringService)
    {
        _mirroringService = mirroringService;
    }


    public string CreateLine(string letter, string upTo)
    {
        var delta = upTo[0] - ALPHABETH_START;
        var result = string.Empty;
        for (int i = 0; i < delta + 1; i++)
        {

            var newPosition = upTo[0] - letter[0] == i
                ? letter
                : " ";
            result += newPosition;
            
        }
        return result;
    }
}
