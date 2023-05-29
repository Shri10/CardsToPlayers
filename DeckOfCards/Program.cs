namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //♣♢♡♠
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            //string[] suits = { "Clubs ♣", "Diamonds ♢", "Hearts ♡", "Spades ♠" };
            //string[] suits = { "♣", "♢", "♡", "♠" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };


            // Adding / Making all the cards
            List<string> deck = new List<string>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add(rank + " of " + suit);
                }
            }

            // Shuffling of the deck
            Random rndm = new Random();
            for (int n = deck.Count - 1; n > 0; n--)
            {
                int k = rndm.Next(n + 1);
                string temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }

            // Pass the cards to players
            const int players = 4;
            const int cardsPerPlayer = 9;
            string[,] hands = new string[players, cardsPerPlayer];

            int cardINdex = 0;
            for (int i = 0; i < players; i++) 
            {
                for (int j = 0; j < cardsPerPlayer; j++)
                {
                    hands[i, j] = deck[cardINdex];
                    cardINdex++;
                }
            }

            // Print each Player's Hand
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Player " + (i+1) + "'s Hand:");
                for (int j = 0; j < cardsPerPlayer; j++)
                {
                    Console.WriteLine("\t" + hands[i, j]);
                }
            }



        }
    }
}