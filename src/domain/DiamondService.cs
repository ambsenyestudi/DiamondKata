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
            var letters = _letterRepository.GetUpTo(letter);
            var lines = new List<DiamondLine>();
            for (int i = 0; i < letters.Count; i++)
            {
                lines.Add(new DiamondLine(letters[i], letters.Count));
            }
            return new Diamond(lines);
        }
    }
}
