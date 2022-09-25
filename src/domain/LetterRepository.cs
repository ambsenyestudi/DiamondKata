namespace Diamonds.Domain
{
    public class LetterRepository
    {
        private readonly List<string> _letters = Enumerable
            .Range('A', ('Z' - 'A' + 1))
            .Select(i => (char)i+"").ToList();

        public List<string> GetUpTo(string letter) =>
            throw new NotImplementedException();
    }
}
