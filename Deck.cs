using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    public class Deck
    {
        public Card[] deck;
        private int currentCard;

        public Deck()
        {
            string[] value = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suit = { "Hearts", "Diamonds", "Spades", "Clubs" };
            deck = new Card[52];
            currentCard = 0;
            for(int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(value[count % 11], suit[count / 13]);
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            currentCard = 0;
            for(int first = 0; first < deck.Length; first++)
            {                
                int second = random.Next(52);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;

            }
        }

        public Card Deal()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
