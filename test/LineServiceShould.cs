using Diamonds.Domain;

namespace Diamonds.Test
{
    public class LineServiceShould
    {
        private readonly LineService _lineService = new LineService(new MirroringService());

        [Theory]
        [InlineData("A","A")]
        [InlineData("C", "C")]
        public void StartLineWith(string input, string expected)
        {
            Assert.Equal(expected, _lineService.CreateLine(input));
        }
    }
}
