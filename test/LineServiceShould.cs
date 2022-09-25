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
            Assert.Equal(expected, _lineService.CreateLine(input, upTo).First().ToString());
        }

        [Theory]
        [InlineData("A", " ", "A\n")]
        [InlineData("C", "C", "C\n")]
        public void EndLineWith(string input, string expected, string upTo)
        {
            Assert.Equal(expected, _lineService.CreateLine(input, upTo).Last().ToString());
        }
    }
}
