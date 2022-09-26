namespace Diamonds.Domain
{
    public record DiamondLine
    {
        private const int MIRROR_OFFSET = 1;
        public char Letter { get; }
        public int Width { get; }

        public DiamondLine(char letter, int width) => (Letter, Width) = (letter, width);

        public override string ToString()
        {
            var line = "";
            var offset = Letter - 'A';
            for (int i = 0; i < Width; i++)
            {
                line += i == offset
                    ? Letter
                    : " ";
            }
            return Mirror(line, MIRROR_OFFSET) + line;
        }

        private static string Mirror(string line, int offset) =>
            new string(line.Skip(offset).Reverse().ToArray());
    }
}
