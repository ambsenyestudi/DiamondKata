using Diamonds.Domain;

namespace Diamonds.Test
{
    public class LineServiceShould
    {
        private readonly LineService _lineService = new LineService(new MirroringService());

        [Fact]
        public void FigureLine()
        {
            var input = "A";
            var expected = "A";
            Assert.Equal(expected, _lineService.CreateLine(input));
        }
    }
}
