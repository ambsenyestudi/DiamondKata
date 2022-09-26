namespace Diamonds.Domain;

public class LetterRepository : ILetterRepository
{
    private const int ALPHABETH_COUNT = 52;
    private readonly List<char> _letters = Enumerable.Range('A', ALPHABETH_COUNT).Select(i => (char)i).ToList();
    public List<char> GetUpTo(char lastLetter) =>
            _letters.Take(GetLetterCount(lastLetter)).ToList();

    private int GetLetterCount(char letter) =>
        _letters.IndexOf(letter) + 1;
}
