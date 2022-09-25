using Diamonds.Domain;

namespace Diamonds.Test;

public class LetterRepositoryShould
{
    private readonly LetterRepository _letterRepository = new();

    [Theory]
    [InlineData("A", "A")]
    [InlineData("A,B,C,D", "D")]
    public void GetLettersUpTo(string expected, string input)
    {
        Assert.Equal(expected, string.Join(",", _letterRepository.GetUpTo(input)));
    }
}
