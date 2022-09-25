using Diamonds.Domain;

namespace Diamonds.Test;

public class DiamondFeature
{
    [Fact]
    public void PrintsDiamondC()
    {
        var exptected = "  A\n";
        exptected += " B B\n";
        exptected += "C   C\n";
        exptected += " B B\n";
        exptected += "  A\n";

        var diamond = new Diamond("C");
        Assert.Equal(exptected, diamond.Print());
    }
}