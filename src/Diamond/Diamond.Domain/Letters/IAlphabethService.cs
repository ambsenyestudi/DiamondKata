namespace Diamond.Domain.Letters
{
    public interface IAlphabethService
    {
        
        bool IsValidDimondLetter(char letter);
        int GetAlphabethPosition(char letter);
        char GetAlphabetLetterAt(int alphabethPosition);
    }
}
