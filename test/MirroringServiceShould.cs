using Diamonds.Domain;

namespace Diamonds.Test;

public class MirroringServiceShould
{
    private readonly MirroringService _mirroringService = new MirroringService();

    [Theory]
    [InlineData("   A   ", "   A")]
    [InlineData("C     C", "C   ")]
    public void Mirror(string expected, string input)
    {
        Assert.Equal(expected, _mirroringService.Mirror(input));
    }
}
