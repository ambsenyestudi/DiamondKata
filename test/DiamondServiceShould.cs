using Diamonds.Domain;
using Moq;

namespace Diamonds.Test
{
    public class DiamondServiceShould
    {
        private readonly Mock<IDiamondLineService> _lineService = new Mock<IDiamondLineService>();
        private readonly Mock<ILetterRepository> _letterRepository = new Mock<ILetterRepository>();
        private readonly DiamondService _diamondService;
        public DiamondServiceShould()
        {
            _diamondService = new DiamondService(_lineService.Object, _letterRepository.Object);
        }

        [Fact]
        public void Create()
        {
            var letter = 'C';
            var expected =
            "  A\n" +
            " B B\n" +
            "C   C\n" +
            " B B\n" +
            "  A\n";
            _letterRepository.Setup(x => x.GetUpTo(letter))
                .Returns(new List<char> { 'A', 'B', 'C' });
            _lineService.Setup(x => x.CreateLines('C'))
                .Returns(new List<DiamondLine> 
                { 
                    new DiamondLine('A', 3),
                    new DiamondLine('B', 3),
                    new DiamondLine('C', 3)
                });
            var diamond = _diamondService.Create(letter);
            Assert.Equal(expected, diamond.Print());
        }
    }
}
