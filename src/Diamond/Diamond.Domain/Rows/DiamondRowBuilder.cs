using Diamond.Domain.Letters;

namespace Diamond.Domain.Rows
{
    public class DiamondRowBuilder
    {
        private const string SPACE = " ";

        private readonly IAlphabethService alphabethService;
        private char letter;
        private int pyramidHeight;
        public DiamondRowBuilder(IAlphabethService alphabethService)
        {
            this.alphabethService = alphabethService;
        }
        public DiamondRowBuilder WithLetter(char letter)
        {
            this.letter = letter;
            return this;
        }
        public DiamondRowBuilder WithPyramidHeight(int pyramidHeight)
        {
            this.pyramidHeight = pyramidHeight;
            return this;
        }
        public DiamondRow Build()
        {
            var result = CreateRow(letter,pyramidHeight,alphabethService);
            return new DiamondRow(result);
        }
        private string CreateRow(char letter, int pyramidHeight, IAlphabethService alphabethLookupService)
        {
            var letterOrder = alphabethLookupService.GetAlphabethPosition(letter);
            var endSpaces = GetEndSpaces(letterOrder, pyramidHeight);
            var center = GetCenter(letterOrder, alphabethLookupService);
            return $"{endSpaces}{center}{endSpaces}";
        }
        public string GetCenter(int index, IAlphabethService alphabethLookupService)
        {
            var currentLetter = alphabethLookupService.GetAlphabetLetterAt(index);
            if (index == 0)
            {
                return "" + currentLetter;
            }
            var nCenterSpace = index * 2 - 1;
            var centerSpace = GetCenterSpace(nCenterSpace);

            var result = $"{currentLetter}{centerSpace}{currentLetter}";
            return result;
        }
        public string GetEndSpaces(int index, int total)
        {
            return BuildSpaces(total - index);
        }
        private string GetCenterSpace(int i)
        {
            return BuildSpaces(i);
        }
        private string BuildSpaces(int spaceCount)
        {
            var spaces = string.Empty;
            for (int n = 0; n < spaceCount; n++)
            {
                spaces += SPACE;
            }
            return spaces;
        }

    }
}
