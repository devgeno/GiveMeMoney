using System;

namespace GiveMeMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameManager gameManager = new GameManager();
            gameManager.AddPlayer(new Player("Geno", 999));
            gameManager.AddPlayer(new Player("Solmi", 999));
            gameManager.Gaming();
        }

    }
}
