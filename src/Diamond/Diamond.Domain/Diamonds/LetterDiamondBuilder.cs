using Diamond.Domain.Letters;
using Diamond.Domain.Rows;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Diamond.Domain.Diamonds
{
    public class LetterDiamondBuilder
    {
        private readonly IAlphabethService alphabethService;
        private char letter;

        public LetterDiamondBuilder(IAlphabethService alphabethService)
        {
            
            this.alphabethService = alphabethService;
        }
        public LetterDiamondBuilder WithLetter(char letter)
        {
            if (!alphabethService.IsValidDimondLetter(letter))
            {
                throw new InvalidOperationException($"letter {letter} is not valid");
            }
            this.letter = letter;
            return this;
        }
        public LetterDiamond Build()
        {
            var diamondRowList = CreateDimondRows(letter, alphabethService).ToList();
            return new LetterDiamond(diamondRowList);
        }

        private IEnumerable<DiamondRow> CreateTopRows(char letter, IAlphabethService alphabethService)
        {
            
            var pyramidHeight = alphabethService.GetAlphabethPosition(letter);
            var max = pyramidHeight + 1;
            var resultList = new List<DiamondRow>();
            for (int i = 0; i < max; i++)
            {
                var currLetter = alphabethService.GetAlphabetLetterAt(i);
                var nextDiamondRow = new DiamondRowBuilder(alphabethService)
                    .WithLetter(currLetter)
                    .WithPyramidHeight(pyramidHeight)
                    .Build();
                resultList.Add(nextDiamondRow);
            }
            return resultList;
        }
        private IEnumerable<DiamondRow> CreateDimondRows(char letter, IAlphabethService alphabethLookup)
        {
            var resultList = CreateTopRows(letter, alphabethLookup);
            return resultList.Concat(resultList.ToArray().Reverse());
        }
    }
}
