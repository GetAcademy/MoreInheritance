namespace TextElementsAsIntroToInterface
{
    internal class TextElement
    {
        private readonly string _text;

        protected TextElement(string text)
        {
            _text = text;
        }

        public virtual void Show()
        {
            Console.WriteLine(_text);
        }
    }
}
