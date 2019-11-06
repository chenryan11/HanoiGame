using System;

namespace HanoiGameMain
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiGame game = new HanoiGame();
            game.Setup();
            game.Play();

            Console.ReadKey();
        }
    }
}
