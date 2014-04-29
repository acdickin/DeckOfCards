using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck d = new Deck();
            List<Card> cards = d.GetCard();
            foreach  (Card card in cards)
            {
                Console.WriteLine(card.Suit + " " + card.Num);

            }
            Console.ReadLine();
        }
    }
}
