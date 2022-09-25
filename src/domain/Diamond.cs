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
        var letters = _letterRepository.GetUpTo(letter);
        var lines = new List<string>();
        for (int i = 0; i < letters.Count; i++)
        {
            lines.Add(_lineService.CreateLine(letters[i], letter));
        }
        return _lineService.MirrorLines(lines);
    }
}
