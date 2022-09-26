using Diamonds.Domain;

namespace Diamonds.Test
{
    public class DiamondLineShould
    {
        [Theory]
        [InlineData("  A  ", 'A')]
        [InlineData(" B B ", 'B')]
        [InlineData("C   C", 'C')]
        public void PrintLike(string expected, char letter)
        {
            var line = new DiamondLine(letter, 3);
            Assert.Equal(expected, line.ToString());
        }
    }
}
