using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class DeckOfCards
    {
        private Card[] deck;
        private int currCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randNum;

        public class Card
        {
            private string face;
            private string suit;

            public Card() { }

            public Card(string cardFace, string cardSuit)
            {
                face = cardFace;
                suit = cardSuit;
            }

            public override string ToString()
            {
                return face + "Of" + suit;
            }
        }
        public DeckOfCards()
        {
            string[] faces = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            string[] suits = {"Diamond", "Spade", "Clover", "Heart"};

            deck = new Card[NUMBER_OF_CARDS];
            currCard = 0;
            randNum = new Random();

            for (int count = 0; count < deck.Length; count++)
            {
                //faces will never be greater than 10
                //suits will not be greater than 3
                deck[count] = new Card(faces[count%11], suits[count/13]);
            }
        }

        public void Shuffle()
        {
            currCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randNum.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }

        }

        public Card DealCard()
        {
            if (currCard < deck.Length)
            {
                return deck[currCard++];
            }
            else return null;
        }
    }


}