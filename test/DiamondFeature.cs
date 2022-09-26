using Diamonds.Domain;

namespace Diamonds.Test;

public class DiamondFeature
{
    private readonly DiamondService _diamondService = new DiamondService(new DiamondLineService(), new LetterRepository());
    [Fact]
    public void PrintDiamondC()
    {
        var diamond = _diamondService.Create('C');
        var expected = 
            "  A\n" +
            " B B\n" +
            "C   C\n" +
            " B B\n" +
            "  A\n";
        Assert.Equal(expected, diamond.Print());
    }
}