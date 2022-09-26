namespace Diamonds.Domain;
public class Diamond
{
    private readonly char _letter;

    public Diamond(char letter)
    {
        _letter = letter;
    }

    public string Print() =>
        throw new NotImplementedException();
}
