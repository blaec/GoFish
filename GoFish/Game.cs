using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
            {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        /// <summary>
        /// This is where the game starts—this method's only called at the beginning of the game.
        /// Shuffle the stock, deal five cards to each player,
        /// then use a foreach loop to call each player's PullOutBooks() method.
        /// </summary>
        private void Deal()
        {
            stock.Shuffle();
            foreach (Player player in players)
            {
                
                for (int i = 0; i < 5; i++)
                {
                    player.TakeCard(stock.Deal());
                }
                PullOutBooks(player);
            }
        }

        /// <summary>
        /// Pull out a player's books.
        /// Each book is added to the Books dictionary.
        /// A player runs out of cards when he's used all of his cards to make books—and he wins the game.
        /// </summary>
        /// <param name="player">player</param>
        /// <returns>Return true if the player ran out of cards, otherwise return false.</returns>
        public bool PullOutBooks(Player player)
        {
            List<Values> playerBooks = (List<Values>)player.PullOutBooks();
            if (playerBooks.Count > 0)
            {
                foreach (Values playerBook in playerBooks)
                {
                    books.Add(playerBook, player);
                    for (int i = 0; i < 4; i++)
                    {
                        player.TakeCard(stock.Deal());
                    }
                }
            }

            return player.CardCount == 0;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        /// <summary>
        /// Return a long string that describes everyone's books by looking at the Books dictionary: 
        /// "Joe has a book of sixes. (line break) Ed has a book of Aces."
        /// </summary>
        /// <returns></returns>
        public string DescribeBooks()
        {
            string description = "";
            foreach (Values key in books.Keys)
            {
                description += $"{books.GetValueOrDefault(key).Name} has a book of {Card.Plural(key)}.{Environment.NewLine}";
            }
            return description;
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += $"{players[i].Name} has {players[i].CardCount}";
                description += (players[i].CardCount == 1)
                    ? $" card.{Environment.NewLine}"
                    : $" cards.{Environment.NewLine}";
            }
            description += $"The stock has {stock.Count} cards left.";
            return description;
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            // Play one round of the game. The parameter is the card the player selected
            // from his hand—get its value. Then go through all of the players and call
            // each one's AskForACard() methods, starting with the human player (who's
            // at index zero in the Players list—make sure he asks for the selected
            // card's value). Then call PullOutBooks()—if it returns true, then the
            // player ran out of cards and needs to draw a new hand. After all the players
            // have gone, sort the human player's hand (so it looks nice in the form).
            // Then check the stock to see if it's out of cards. If it is, reset the
            // TextBox on the form to say, "The stock is out of cards. Game over!" and return
            // true. Otherwise, the game isn't over yet, so return false.
            throw new NotImplementedException();
        }

        public string GetWinnerName()
        {
            // This method is called at the end of the game. It uses its own dictionary
            // (Dictionary<string, int> winners) to keep track of how many books each player
            // ended up with in the books dictionary. First it uses a foreach loop
            // on books.Keys—foreach (Values value in books.Keys)—to populate
            // its winners dictionary with the number of books each player ended up with.
            // Then it loops through that dictionary to find the largest number of books
            // any winner has. And finally it makes one last pass through winners to come
            // up with a list of winners in a string ("Joe and Ed"). If there's one winner,
            // it returns a string like this: "Ed with 3 books". Otherwise, it returns a
            // string like this: "A tie between Joe and Bob with 2 books."
            throw new NotImplementedException();
        }
    }
}
