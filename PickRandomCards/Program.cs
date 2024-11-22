//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace PickRandomCards 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.pickSomeCards(numberOfCards);
                foreach (string card in cards)
                {
                    Console.WriteLine(card);
                }
            } 
            else
            {
                Console.WriteLine("Could not parse int; please enter an integer.");
            }
            

        }
    }
}
