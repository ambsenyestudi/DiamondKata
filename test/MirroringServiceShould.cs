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

    [Theory]
    [InlineData("A", "A\nA\n")]
    public void MirrorLines(string inputRaw, string expected)
    {
        var input = inputRaw.Split(",").ToList();
        Assert.Equal(expected, _mirroringService.Mirror(input));
    }
}
