using Diamonds.Domain;

namespace Diamonds.Test;

public class MirroringServiceShould
{
    private readonly MirroringService _mirroringService = new MirroringService();

    [Fact]
    public void Mirror()
    {
        var expected = "   A   ";
        Assert.Equal(expected, _mirroringService.Mirror("   A"));
    }
}
