namespace Diamonds.Domain;
public class Diamond
{
    private LineService _lineService;
    private LetterRepository _letterRepository;

    public Diamond(LineService lineService, LetterRepository letterRepository)
    {
        _lineService = lineService;
        _letterRepository = letterRepository;
    }


    public string Print(string letter)
    {
        throw new NotImplementedException();
    }
}
