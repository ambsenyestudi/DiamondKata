namespace Diamonds.Domain;

public class DiamondLineService : IDiamondLineService
{
    private readonly ILetterRepository _letterRepository;

    public DiamondLineService(ILetterRepository letterRepository)
    {
        _letterRepository = letterRepository;
    }

    public List<DiamondLine> CreateLines(char letter)
    {
        var letters = _letterRepository.GetUpTo(letter);
        var lines = new List<DiamondLine>();
        for (int i = 0; i < letters.Count; i++)
        {
            lines.Add(new DiamondLine(letters[i], letters.Count));
        }
        return lines;
    }
}
