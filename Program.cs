using System;

namespace Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            for(int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck.Deal());
                Console.ReadLine();
            }
        }
    }
}
