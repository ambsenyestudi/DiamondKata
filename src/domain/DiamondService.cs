namespace Diamonds.Domain
{
    public class DiamondService
    {
        private readonly IDiamondLineService _lineService;

        public DiamondService(IDiamondLineService lineService)
        {
            _lineService = lineService;
        }

        public Diamond Create(char letter) =>
            new Diamond(_lineService.CreateLines(letter));
    }
}
