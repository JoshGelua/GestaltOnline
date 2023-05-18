using System;

namespace GestaltPOC.Source
{
    class Program
    {
        static void Main(string[] args)
        {
            using var game = new GestaltPOC.Source.Game1();
            game.Run();
        }
    }
}
