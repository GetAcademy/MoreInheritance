using TextElementsAsIntroToInterface;

var textElements = new ITextElement[]
{
    new CenteredHeader("Overskrift", '*'), 
    new BulletPoint("A"), 
    new BulletPoint("B"), 
    new BulletPoint("C"), 
    new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. "),
    new InvertedText("Terje"),
};

foreach (var element in textElements)
{
    element.Show();
}


