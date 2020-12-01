using System.Collections.Generic;

namespace Diamond.Domain.Letters
{
    public interface IAlphabethProvider
    {
        List<char> Alphabeth { get; }
    }
}
