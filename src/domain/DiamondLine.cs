namespace Diamonds.Domain
{
    public record DiamondLine
    {
        public char Letter { get; }
        public int Width { get; }

        public DiamondLine(char letter, int width) => (Letter, Width) = (letter, width);

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
