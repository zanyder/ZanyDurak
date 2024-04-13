/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: GameRiver class, this class will hold a list of the cards
 that are at the center of the gameplay. The river begins when an attacker sets a card into play
 and it grows everytime a defensive or offensive card is added to play. 
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DurakLibrary;

namespace DurakLibrary
{
    public class GameRiver: ICloneable 
    {
        //instance attributes
        CardList riverCards = new CardList();
        private int riverCardsRemaning = 0;
        private int roundNumber = 0;
        // Constant that represents the maximum amount of cards
        // that can be used in a single run of attacks and defense. 
        private int MAX_RIVER_CARDS = 12;
        


        public int RiverCount()
        {
            return riverCards.Count;
        }

        public Card GetCard(int index)
        {
           
            if (index >= 0 && index <= 51)
                return riverCards[index];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", index,
                       "Value must be between 0 and 51."));

        }
        //addcardtoriver method, will add a card to river
        // This method is called when a card is played for attack
        // or defense on the game board. 
        public void AddCardToRiver(Card card)
        {
            riverCards.Add(card);
            riverCardsRemaning = RiverCount();
        }


        // shows the length of the river
        // Used to check that the max amount of 
        // attacks and defense have not been met. 
        // RETURNS TRUE WHEN THE MAX LENGTH HAS BEEN REACHED 
        public bool checkRiverLength(GameRiver gameRiver)
        {
            if (RiverCount() >= MAX_RIVER_CARDS) {
                return true;
            }
            else {
                return false; 
            }
        }

        //clones the river cards
        public object Clone()
        {
            GameRiver newGameRiver = new GameRiver(riverCards.Clone() as CardList);
            return newGameRiver;
        }

        //parameriterized constructor sets new gameriver
        private GameRiver(CardList newGameRiver)
        {
            riverCards = newGameRiver;
        }

        //default constructor
        public GameRiver()
        {

        }

        //clears the river
        // Will be called at the end of every 
        // river run, when the cards are discarded or 
        // picked up by the loser of the interaction. 
        public void ClearRiver()
        {
            riverCards.Clear();
        }

        //to string will output as a string game river cards
        public String ToString(GameRiver gameRiver1)
        {
            String gameRiverString = "";

            gameRiverString += "\n\n\tRiverCards\n\t";
            for (int i = 0; i < gameRiver1.RiverCount(); i++)
            {
                Card tempCard = gameRiver1.GetCard(i);
                gameRiverString+=tempCard.ToString();
                if (i != 51)
                    gameRiverString +=", ";

            }

            return gameRiverString;
        }

        //gets river card count
        public int getCardsRemaining()
        {
            return riverCardsRemaning = riverCards.Count;
        }


    }
}
