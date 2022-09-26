namespace Diamonds.Domain;

public interface ILetterRepository
{
    List<char> GetUpTo(char lastLetter);
}
