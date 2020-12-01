namespace Diamond.Domain.Letters
{
    public class AlphabethService: IAlphabethService
    {
        private readonly IAlphabethProvider alphabethProvider;

        public AlphabethService(IAlphabethProvider alphabethProvider)
        {
            this.alphabethProvider = alphabethProvider;
        }

        public int GetAlphabethPosition(char letter) =>
            alphabethProvider.Alphabeth.IndexOf(letter);

        public bool IsValidDimondLetter(char letter) =>
            alphabethProvider.Alphabeth.Contains(letter);

        public char GetAlphabetLetterAt(int alphabethPosition) =>
            alphabethProvider.Alphabeth[alphabethPosition];
    }
}
