using System.Collections.Generic;

namespace Diamond.Domain.Letters
{
    public class AlphabethProvider: IAlphabethProvider
    {
        public List<char> Alphabeth { get; }
        public AlphabethProvider()
        {
            Alphabeth = new List<char>
            {
                'A','B','C','D','E',
                'F','G','H','I','J',
                'K','L','M','N','O',
                'P','Q','R','S','T',
                'U','V','W','X','Y',
                'Z'
            };
        }
    }
}
