namespace Diamonds.Domain
{
    public record DiamondLine
    {
        private const int MIRROR_OFFSET = 1;
        private const string SPACE = " ";

        public char Letter { get; }
        public int Width { get; }

        public DiamondLine(char letter, int width) => (Letter, Width) = (letter, width);

        public override string ToString()
        {
            var offset = Letter - 'A';
            var line = Compose(offset);
            return Mirror(line, MIRROR_OFFSET) + line;
        }

        private string Compose(int offset)
        {
            string line = string.Empty;
            for (int i = 0; i < Width; i++)
            {
                line += i == offset
                    ? Letter
                    : SPACE;
            }

            return line;
        }

        private static string Mirror(string line, int offset) =>
            new string(line.Skip(offset).Reverse().ToArray());
    }
}
