namespace TextElementsAsIntroToInterface
{
    internal class BulletPoint : TextElement
    {
        public BulletPoint(string text) : base(text)
        {
        }

        public override void Show()
        {
            Console.Write(" * ");
            base.Show();
        }
    }
}
