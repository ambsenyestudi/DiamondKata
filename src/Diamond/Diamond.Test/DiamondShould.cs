using Diamond.Domain;
using Diamond.Domain.Diamonds;
using Diamond.Domain.Letters;
using Diamond.Domain.Rows;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Diamond.Test
{
    public class DiamondShould {
        private AlphabethService alphabethLookupService;

        public DiamondShould()
        {
            alphabethLookupService = new AlphabethService(new AlphabethProvider());
        }
        [InlineData('A', 2)]
        [InlineData('B', 4)]
        [Theory]
        public void PrintAsManyRowsAsAlphabethOrder(char letter, int rowCount)
        {
            var aDimond = new LetterDiamondBuilder(alphabethLookupService)
                .WithLetter(letter)
                .Build();
            var resultRows = aDimond.RowList;

            Assert.Equal(rowCount, resultRows.Count);
        }

        [InlineData('A', "A,A" )]
        [InlineData('B', " A ,B B,B B, A ")]
        [InlineData('C', "  A  , B B ,C   C,C   C, B B ,  A  ")]
        [Theory]
        public void Match(char letter, string match)
    {

            var expectedDimond = BuildDiamondFromString(match);
            var actualDiamond = new LetterDiamondBuilder(alphabethLookupService)
                .WithLetter(letter)
                .Build(); 
            
            Assert.Equal(expectedDimond, actualDiamond);
        }

        private List<DiamondRow> BuildRowListFromString(string matchingString) => 
            matchingString.Split(',')
                .Select(m => new DiamondRow(m))
                .ToList();
        private LetterDiamond BuildDiamondFromString(string matchingString) =>
            new LetterDiamond(BuildRowListFromString(matchingString));
    }
}
