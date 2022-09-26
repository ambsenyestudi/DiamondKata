using Diamonds.Domain;
using Moq;

namespace Diamonds.Test;

public class DiamondLineServiceShould
{
    private readonly Mock<ILetterRepository> _letterRepository = new Mock<ILetterRepository>();
    private readonly DiamondLineService _lineService;
    public DiamondLineServiceShould()
    {
        _lineService = new DiamondLineService(_letterRepository.Object);
    }
    
    [Fact]
    public void CreateLines()
    {
        var input = 'B';
        var expected =new List<string>
        {
            " A ",
           "B B"
        };
        _letterRepository.Setup(x => x.GetUpTo(input)).Returns(new List<char> { 'A', 'B' });
        var lines = _lineService.CreateLines('B');
        Assert.Equal(expected, lines.Select(x => x.ToString()).ToList());
    }
}
