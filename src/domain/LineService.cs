namespace Diamonds.Domain;

public class LineService
{
    private readonly MirroringService _mirroringService;

    public LineService(MirroringService mirroringService)
    {
        _mirroringService = mirroringService;
    }

    public string CreateLine(string Letter) =>
        throw new NotImplementedException();
}
