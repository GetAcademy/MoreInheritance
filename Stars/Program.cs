using System.Text;
using StarsFromInterfaceToInheritance;

Console.OutputEncoding = Encoding.UTF8;
Console.CursorVisible = false;
var stars = new Star[]
{
    new BlinkingStar(40, 5), 
    new MovingStar(5, 10, 1, 0),
    new Star(20, 3),
};

while (true)
{
    Console.Clear();
    foreach (var star in stars)
    {
        star.Show();
        star.Update();
    }
    Thread.Sleep(200);
}