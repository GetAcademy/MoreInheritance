namespace TextElementsAsIntroToInterface
{
    internal class CenteredHeader : TextElement
    {
        private readonly string _paddedText;

        public CenteredHeader(string text, char paddingChar)
        : base(text)
        {
            var startPos = (Console.WindowWidth - text.Length) / 2;
            var padCount = startPos - 4;
            var padding = "  " + new string(paddingChar, padCount) + "  ";
            _paddedText = padding + text + padding;
        }

        public override void Show()
        {
            Console.WriteLine(_paddedText);
        }
    }
}
