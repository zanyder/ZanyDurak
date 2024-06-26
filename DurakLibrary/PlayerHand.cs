﻿/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: PlayerHand class, keeps track of cards in players hands
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    public class PlayerHand : ICloneable
    {
        //instance attributes
        private CardList playerHand = new CardList();
        private int numberOfCardsRemaning = 0;

        //default constructor
        public PlayerHand()
        {

        }

        //parameterized constructor
        public PlayerHand(CardList newPlayerHand)
        {
            playerHand = newPlayerHand;
        }

        //clone method
        //returns a clone of playerhand
        public object Clone()
        {
            PlayerHand newplayerHand = new PlayerHand(playerHand.Clone() as CardList);
            return newplayerHand;
        }

        //addcardtohand method, will add a card to the players hand
        public void AddCardToHand(Card card)
        {
            playerHand.Add(card);
            numberOfCardsRemaning = playerHand.Count();
        }

        //will add cards to players hand
        public void AddCardsToHand(CardList cards)
        {
            for (int i = 0; i < cards.Count(); i++)
            {
                playerHand.Add(cards[i]);
            }

            numberOfCardsRemaning = playerHand.Count();
        }

        //removecardfromhand method, will remove a card from the players hand
        public void RemoveCardFromHand(Card card)
        {
            playerHand.Remove(card);
            numberOfCardsRemaning = playerHand.Count();
        }

        //gets hand count
        public int length()
        {
            return playerHand.Count();
        }

        //choosecardfromhand method, will select a specific card from the hand then remove from list
        public Card ChooseCardFromHand(int choosenCardNumber)
        {
            Card card;
            card = playerHand.ElementAt(choosenCardNumber);
            //playerHand.Remove(card);
            return card;
        }

        //choose specific card from hand
        public Card ChooseCardFromHand(Card card)
        {
            return card;
        }

        //get card based on int number
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return playerHand[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
        }

        //shows hand as a string
        public static String ToString(PlayerHand playerHand1, String playerName)
        {
            String playerHandString = "";

            playerHandString += playerName.ToString() + "Cards: \n\t";
            for (int i = 0; i < playerHand1.length(); i++)
            {
                Card tempCard = playerHand1.GetCard(i);
                playerHandString += tempCard.ToString();
                if (i != 51)
                    playerHandString += ", ";
            }

            return playerHandString;
        }

        //shows hand as a string, int playernumber
        public static String ToString(PlayerHand playerHand1, int playerNumber)
        {
            String playerHandString = "";

            playerHandString += "\n\nPlayer" + playerNumber.ToString() + "\n";
            for (int i = 0; i < playerHand1.length(); i++)
            {
                Card tempCard = playerHand1.GetCard(i);
                playerHandString += tempCard.ToString();
                if (i != 51)
                    playerHandString += ", ";
            }

            return playerHandString;
        }
    }
}

