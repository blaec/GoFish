﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }

        private Random random;

        private Deck cards;

        private TextBox textBoxOnForm;

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += $"{name} has just joined the game.{Environment.NewLine}";
        }

        public Values GetRandomValue()
        {
            return cards.Peek(random.Next(cards.Count)).Value;
        }

        /// <summary> 
        /// This is where an opponent asks if I have any cards of a certain value 
        /// Use Deck.PullOutValues() to pull out the values. 
        /// Add a line to the TextBox that says, "Joe has 3 sixes"—use the new Card.Plural() static method
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Deck DoYouHaveAny(Values value)
        {
            Deck pullCards = cards.PullOutValues(value);
            if (pullCards.Count > 0)
            {
                textBoxOnForm.Text += $"{Name} has {pullCards.Count} {Card.Plural(value)}{Environment.NewLine}";
            }
            return pullCards;
        }

        /// <summary>
        /// Here's an overloaded version of AskForACard() —
        /// choose a random value from the deck using GetRandomValue() and ask for it using AskForACard()
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            AskForACard(players, myIndex, stock, GetRandomValue());
        }

        /// <summary>
        /// Ask the other players for a value.
        /// First add a line to the TextBox: "Joe asks if anyone has a Queen".
        /// Then go through the list of players that was passed in as a parameter 
        /// and ask each player if he has any of the value (using his DoYouHaveAny() method).
        /// He'll pass you a deck of cards—add them to my deck.
        /// Keep track of how many cards were added.
        /// If there weren't any, you'll need to deal yourself a card from the stock 
        /// (which was also passed as a parameter), 
        /// and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        /// <param name="value"></param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            bool goFish = true;
            textBoxOnForm.Text += $"{players[myIndex].Name} asks if anyone has a {value}{Environment.NewLine}";
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Deck pulledCards = players[i].DoYouHaveAny(value);
                    if (pulledCards.Count > 0)
                    {
                        goFish = false;
                        for (int c = 0; c < pulledCards.Count; c++)
                        {
                            players[myIndex].TakeCard(pulledCards.Deal(c));
                        }
                    }
                }
            }
            if (goFish)
            {
                players[myIndex].TakeCard(stock.Deal());
                textBoxOnForm.Text += $"{players[myIndex].Name} had to draw from the stock.{Environment.NewLine}";
            }
        }

        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }

                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
    }
}
