using Diamonds.Domain;

namespace Diamonds.Test
{
    public class LineServiceShould
    {
        private readonly LineService _lineService = new LineService(new MirroringService());

        [Theory]
        [InlineData("A","A")]
        [InlineData("C", "C")]
        public void Contains(string input, string expected)
        {
            Assert.Contains(expected, _lineService.CreateLine(input, input));
        }

        [Theory]
        [InlineData("A", " ", "C")]
        [InlineData("C", "C", "C")]
        public void StartLineWith(string input, string expected, string upTo)
        {
            Assert.StartsWith(expected, _lineService.CreateLine(input, upTo));
        }

        [Theory]
        [InlineData("A", "A\n", "C")]
        [InlineData("C", "C\n", "C")]
        public void EndLineWith(string input, string expected, string upTo)
        {
            Assert.EndsWith(expected, _lineService.CreateLine(input, upTo));
        }
    }
}
