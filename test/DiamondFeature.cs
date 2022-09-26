using Diamonds.Domain;

namespace Diamonds.Test;

public class DiamondFeature
{
    [Fact]
    public void PrintDiamondC()
    {
        var diamond = new Diamond('C');
        var expected = 
            "  A\n" +
            " B B\n" +
            "C   C\n" +
            " B B\n" +
            "  A\n";
        Assert.Equal(expected, diamond.Print());
    }
}