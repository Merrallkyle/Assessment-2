using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    public class Card
    {
        private string suit;
        private string value;

        public Card(string cardValue, string cardSuit)
        {
            suit = cardSuit;
            value = cardValue;
        }

        public override string ToString()
        {
            return value + " of " + suit;
        }
    }
}
