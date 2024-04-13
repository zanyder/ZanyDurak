/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: Card class, sets up and defines a single playing card for 
 any instances of rank and suit. This class also overloads relational
 operators for card objects 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakLibrary
{
    /// <summary>
    /// Represents a playing card with a specific rank and suit.
    /// </summary>
    public class Card : ICloneable
    {
        // Instance attributes
        public readonly CardRanksEnum rank;
        public readonly CardSuitsEnum suit;

        // Class attributes
        public static bool isAceHigh = true;
        public static bool useTrumps = false;
        public static CardSuitsEnum trump;

        /// <summary>
        /// Event handler for handling card click events.
        /// </summary>
        public EventHandler CardClicked { get; set; }

        /// <summary>
        /// Default constructor for Card class.
        /// </summary>
        public Card()
        {
            // Default constructor
        }

        /// <summary>
        /// Parameterized constructor for Card class.
        /// </summary>
        /// <param name="newSuit">The suit of the card.</param>
        /// <param name="newRank">The rank of the card.</param>
        public Card(CardSuitsEnum newSuit, CardRanksEnum newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        /// <summary>
        /// Gets the suit of the card.
        /// </summary>
        /// <returns>The suit of the card.</returns>
        public CardSuitsEnum GetCardSuit()
        {
            return suit;
        }

        /// <summary>
        /// Gets the rank of the card.
        /// </summary>
        /// <returns>The rank of the card.</returns>
        public CardRanksEnum GetCardRank()
        {
            return rank;
        }

        /// <summary>
        /// Clones the current card instance.
        /// </summary>
        /// <returns>A cloned instance of the card.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Converts the card to a string representation.
        /// </summary>
        /// <returns>A string representation of the card, including rank and suit.</returns>
        public override String ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        /// <summary>
        /// Converts the card to a string representation, including player number.
        /// </summary>
        /// <param name="playerNumber">The player number associated with the card.</param>
        /// <returns>A string representation of the card with player number information.</returns>
        public String ToString(int playerNumber)
        {
            return "\nCard Drawn Player " + playerNumber + "\nThe " + rank + " of " + suit + "s";
        }

        /// <summary>
        /// Gets the hash code for the card.
        /// </summary>
        /// <returns>A unique hash code for the card.</returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        //operator overloading methods
        //returns a boolean 
        /// <summary>
        /// Checks if two cards are equal.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the cards are equal in rank and suit, otherwise false.</returns>
        public static bool operator ==(Card card1, Card card2)
        {
  
                return (card1.suit == card2.suit) && (card1.rank == card2.rank);
            
        }

        /// <summary>
        /// Checks if two cards are not equal.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the cards are not identical, otherwise false.</returns>
        public static bool operator !=(Card card1, Card card2)
        {
        
                return !(card1 == card2);
      
        }

        /// <summary>
        /// Checks if the current card is equal to another card.
        /// </summary>
        /// <param name="card">The card to compare with the current card.</param>
        /// <returns>True if the cards are equal, otherwise false.</returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        /// <summary>
        /// Checks if the first card is greater than the second card.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the first card is greater than the second card, otherwise false.</returns>
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanksEnum.Ace)
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// Checks if the first card is less than the second card.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the first card is less than the second card, otherwise false.</returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        /// <summary>
        /// Checks if the first card is greater than or equal to the second card.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the first card is greater than or equal to the second card, otherwise false.</returns>
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanksEnum.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        

        /// <summary>
        /// Checks if the first card is less than or equal to the second card.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the first card is less than or equal to the second card, otherwise false.</returns>
        public static bool operator <=(Card card1, Card card2)
        {
           return !(card1 > card2);
        }



    }
}
