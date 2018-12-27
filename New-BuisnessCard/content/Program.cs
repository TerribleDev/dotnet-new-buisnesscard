using System;
using System.Linq;
namespace content
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToDraw = String.Join(Environment.NewLine, BuisnessCard.Data.Where(a => !String.IsNullOrWhiteSpace(a.When)).Select(a => a.ToString()));
            Console.Write(BoxDraw.Draw(stringToDraw));
        }
    }
}
