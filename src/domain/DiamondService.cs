namespace Diamonds.Domain
{
    public class DiamondService
    {
        private readonly IDiamondLineService _lineService;
        private readonly ILetterRepository _letterRepository;

        public DiamondService(IDiamondLineService lineService, ILetterRepository letterRepository)
        {
            _lineService = lineService;
            _letterRepository = letterRepository;
        }


        public Diamond Create(char letter)
        {
            throw new NotImplementedException();
        }
    }
}
