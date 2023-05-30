# Deck of Cards Program

This C# program is a simple implementation of creating, shuffling, and distributing a deck of cards to a set of players. The deck is a standard deck containing 52 cards - 4 suits with 13 ranks each.

## Functionality:

1. **Creating a deck of cards:** The deck is created using two arrays: `suits` and `ranks`. Each card is a combination of a rank and a suit, like "2 of Hearts" or "King of Spades".

2. **Shuffling the deck:** Once the deck is created, it is shuffled using a standard shuffling algorithm. The shuffling is done in-place, meaning the original deck is shuffled, not a copy of the deck.

3. **Distributing the cards to the players:** The cards are then distributed to a set number of players. The number of players and the number of cards each player should receive are specified by the constants `players` and `cardsPerPlayer`.

4. **Printing each player's hand:** Finally, the program prints out each player's hand to the console. Each player's hand is printed on a new line, with each card indented and printed on its own line.

## Usage:

To run this program, follow these steps:

1. Open a new console application in your preferred C# IDE.
2. Replace the default code with the code provided.
3. Run the program. The hands of the players will be printed to the console.

## Note:

This program does not involve any user input or handle any form of gameplay. It is a simple demonstration of creating, shuffling, and distributing a deck of cards. You could extend this program to include rules for a specific card game, add more players, or add more interactivity.