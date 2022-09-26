using Diamonds.Domain;

namespace Diamonds.Test
{
    public class DiamondLineShould
    {
        [Fact]
        public void PrintLike()
        {
            var expected = "  A  ";
            var line = new DiamondLine('A', 3);
            Assert.Equal(expected, line.ToString());
        }
    }
}
