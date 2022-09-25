using Diamonds.Domain;

namespace Diamonds.Test;

public class DiamondFeature
{
    public readonly Diamond _diamond = new Diamond(
        new LineService(new MirroringService()), new LetterRepository());

    [Fact]
    public void PrintsDiamondC()
    {
        var exptected = "  A\n";
        exptected += " B B\n";
        exptected += "C   C\n";
        exptected += " B B\n";
        exptected += "  A\n";

        Assert.Equal(exptected, _diamond.Print("C"));
    }
}