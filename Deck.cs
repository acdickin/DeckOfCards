using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Deck
    {
        List<Card> cards;
        public Deck()
        {

            cards = new List<Card>();
            initalizeDeck();
        }

        private void initalizeDeck()
        {

            string suit = null;



            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0:

                        suit = "Hearts";
                        break;

                    case 1:

                        suit = "Dimonds";
                        break;

                    case 2:

                        suit = "Clubs";
                        break;

                    case 3:
                        suit = "Spade";
                        break;
                }
                for (int x = 1; x <= 13; x++)
                {
                    Card c = new Card();
                    c.Suit = suit;
                    c.Num = x;
                    cards.Add(c);


                }

            }
        }
        public List<Card> GetCard()
        {
            return cards;
        }

    }
}
