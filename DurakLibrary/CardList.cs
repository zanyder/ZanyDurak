/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: CardList class, sets up and defines a generic list of card 
 objects. Uses cloning to create a new list of cards. Copy to utility 
 method for copying card instances into another cards instance.  
 */

using System;
using System.Collections.Generic;

namespace DurakLibrary
{
    /// <summary>
    /// Represents a generic list of card objects with additional functionality.
    /// </summary>
    public class CardList : List<Card>, ICloneable
    {
        /// <summary>
        /// Creates a clone of the CardList, including cloned Card instances.
        /// </summary>
        /// <returns>A new CardList containing cloned Card instances.</returns>
        public object Clone()
        {
            CardList newCards = new CardList();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }

        /// <summary>
        /// Copies card instances from the current CardList to the target CardList.
        /// </summary>
        /// <param name="targetCards">The destination CardList to copy cards into.</param>
        public void CopyTo(CardList targetCards)
        {
            if (targetCards.Count != this.Count)
            {
                throw new ArgumentException("Source and target collections must have the same size.");
            }

            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Converts the drawn cards to a formatted string, including the player number.
        /// </summary>
        /// <param name="cardsDrawn">The CardList containing the drawn cards.</param>
        /// <param name="playerNumber">The player number associated with the drawn cards.</param>
        /// <returns>A formatted string representation of the drawn cards for a specific player.</returns>
        public String ToString(CardList cardsDrawn, int playerNumber)
        {
            String cardsDrawnString = "";

            cardsDrawnString += $"\n\nDrawnCards Player {playerNumber}\n";
            for (int i = 0; i < cardsDrawn.Count; i++)
            {
                Card tempCard = cardsDrawn.GetCard(i, cardsDrawn);
                cardsDrawnString += tempCard.ToString();
                if (i < cardsDrawn.Count - 1)
                    cardsDrawnString += ", ";
            }

            return cardsDrawnString;
        }

        /// <summary>
        /// Gets a card from the specified CardList based on the card number.
        /// </summary>
        /// <param name="cardNum">The card number representing the position of the card in the CardList.</param>
        /// <param name="cards">The CardList from which to retrieve the card.</param>
        /// <returns>The card at the specified position.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown if the card number is outside the valid range (0 to 51).</exception>
        public Card GetCard(int cardNum, CardList cards)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw new System.ArgumentOutOfRangeException(nameof(cardNum), cardNum,
                    "Value must be between 0 and 51.");
        }
    }
}