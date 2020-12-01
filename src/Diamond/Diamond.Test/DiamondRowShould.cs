using Diamond.Domain.Letters;
using Diamond.Domain.Rows;
using Xunit;

namespace Diamond.Test
{
    public class DiamondRowShould
    {
        private AlphabethService alphabethLookupService;

        public DiamondRowShould()
        {
            alphabethLookupService = new AlphabethService(new AlphabethProvider());
        }
        [InlineData('A', "A")]
        [InlineData('B', "B B")]
        [InlineData('C', "C   C")]
        [InlineData('D', "D     D")]
        [Theory]
        public void MatchAtCenterRow(char letter, string match)
        {
            var expectedRow = new DiamondRow(match);
            var row = new DiamondRowBuilder(alphabethLookupService)
                .WithLetter(letter)
                .WithPyramidHeight(0)
                .Build();
            Assert.Equal(expectedRow, row);
        }

    }
}
