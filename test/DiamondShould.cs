using Diamonds.Domain;

namespace Diamonds.Test
{
    public class DiamondShould
    {
        [Fact]
        public void PrintsLine()
        {
            var exptected = "  A\n";
            exptected += "  A\n";

            var diamond = new Diamond("C");
            Assert.Equal(exptected, diamond.Print());
        }
    }
}
