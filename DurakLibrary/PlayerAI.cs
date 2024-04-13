/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: PlayerAI class, creates all functionality for a computer
 player artificial intelligence
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    /// <summary>
    /// Represents a computer player with artificial intelligence.
    /// </summary>
    public class PlayerAI : Player
    {

        private GameDeck _hand = new GameDeck();
        private bool _isAttacking = false;

        public event EventHandler<string> NoOptionsEvent;
        public bool IsAttacking {
            get { return _isAttacking; }
            set { _isAttacking = value; }
        }

        public GameDeck Hand {
            get { return _hand; }
            set { _hand = value; }
        }
        //default constructor
        /// <summary>
        /// Default constructor for PlayerAI.
        /// </summary>
        public PlayerAI()
        {

        }

        /// <summary>
        /// Parameterized constructor for PlayerAI.
        /// </summary>
        /// <param name="name">The name of the AI player.</param>
        /// <param name="hand">The initial hand of the AI player.</param>
        /// <param name="isAttacking">Flag indicating if the AI is attacking.</param>
        /// <param name="isDefending">Flag indicating if the AI is defending.</param>
        public PlayerAI(String name)
        {
            setName(name);
         
        }

        /// <summary>
        /// Guides the AI through the attacking phase.
        /// </summary>
        /// <param name="gameRiver">The game river.</param>
        public void AttackingPhase(GameRiver gameRiver)
        {

            Card attackingCard = new Card();

            CardList gameRiverList = new CardList();

            bool sucessfullattack = false;

            for (int i = 0; i < gameRiver.RiverCount(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }


            switch (gameRiver.RiverCount())
            {
                case 0:
                    //AI chooses a card 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        sucessfullattack = true;
                        break;
                    }
                    break;

                case 2:
                    //AI chooses a card 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 4:
                    //AI chooses a card 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 6:
                    //AI chooses a card 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank | attackingCard.GetCardRank() == gameRiverList[4].rank | attackingCard.GetCardRank() == gameRiverList[5].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 8:
                    //AI chooses a card 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank | attackingCard.GetCardRank() == gameRiverList[4].rank | attackingCard.GetCardRank() == gameRiverList[5].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;
            }


            if (sucessfullattack == false && gameRiver.RiverCount() == 0 | gameRiver.RiverCount() == 2 | gameRiver.RiverCount() == 4 | gameRiver.RiverCount() == 6 | gameRiver.RiverCount() == 8)
            {
                IsAttacking = false;
            }
            
            if (!sucessfullattack && (gameRiver.RiverCount() == 0 || gameRiver.RiverCount() == 2 || gameRiver.RiverCount() == 4 || gameRiver.RiverCount() == 6 || gameRiver.RiverCount() == 8))
            {
                NoOptionsEvent?.Invoke(this, "AI can no longer attack due to having no options.");
            }
        }


        /// <summary>
        /// Guides the AI through the defending phase.
        /// </summary>
        /// <param name="gameRiver">The game river.</param>
        /// <param name="trumpCard">The trump card.</param>
        public void DefendingPhase(GameRiver gameRiver, Card trumpCard)
        {
                Card defendingCard = new Card();
                CardList gameRiverList = new CardList();
                bool sucessfulldefense = false;

                //int computerInput = 0;
               
                for (int i = 0; i < gameRiver.RiverCount(); i++)
                {
                   gameRiverList.Add(gameRiver.GetCard(i));
                }

                switch (gameRiver.RiverCount())
                {
                    case 1: 
                            //AI chooses a card 
                             for (int i = 0; i < getHand().length(); i++)
                            {
                                 defendingCard = getHand().ChooseCardFromHand(i);

                                 if (defendingCard.GetCardSuit() == gameRiverList[0].suit & defendingCard > gameRiverList[0] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[0])
                                    {
                                gameRiver.AddCardToRiver(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                                 }

                        }                    
                    break;

                    case 3:
                        //AI chooses a card 
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.GetCardSuit() == gameRiverList[2].suit & defendingCard > gameRiverList[2] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[2])
                            {
                                gameRiver.AddCardToRiver(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;


                    case 5:
                        //AI chooses a card 
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.GetCardSuit() == gameRiverList[4].suit & defendingCard > gameRiverList[4] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[4])
                            {
                                gameRiver.AddCardToRiver(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;

                    case 7:
                        //AI chooses a card 
                        for (int i = 0; i < getHand().length(); i++)
                        {
                            defendingCard = getHand().ChooseCardFromHand(i);

                            if (defendingCard.GetCardSuit() == gameRiverList[6].suit & defendingCard > gameRiverList[6] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[6])
                            {
                                gameRiver.AddCardToRiver(defendingCard);
                                getHand().RemoveCardFromHand(defendingCard);
                                sucessfulldefense = true;
                                break;
                            }

                        }
                        break;
                }
            if (!sucessfulldefense && (gameRiver.RiverCount() == 1 || gameRiver.RiverCount() == 3 || gameRiver.RiverCount() == 5 || gameRiver.RiverCount() == 7))
            {
                NoOptionsEvent?.Invoke(this, "AI can no longer defend due to having no options.");
            }
        }



        /// <summary>
        /// Allows the AI to choose a defending card.
        /// </summary>
        private void ChooseDefendingCard(GameRiver gameRiver, Card trumpCard)
        {
            if (getHand().length() > 0)
            {
                // Basic AI logic: Randomly choose a card from the hand.
                Random random = new Random();
                int randomIndex = random.Next(0, getHand().length());

                Card defendingCard = getHand().ChooseCardFromHand(randomIndex);

                // You may want to perform additional checks or apply a more sophisticated AI strategy here.

                // Add defending card to the river and remove it from the hand.
                gameRiver.AddCardToRiver(defendingCard);
                getHand().RemoveCardFromHand(defendingCard);

                // Indicate successful defense.
                setIsAttacking(false);
            }
            else
            {
                // Handle the case where the AI player has no cards in hand.

                // Example: Draw new cards from the deck to replenish the hand.
                

                // You can implement additional actions or strategies based on your game rules.

                // After drawing new cards, the AI can choose a defending card.
                ChooseDefendingCard(gameRiver, trumpCard);
            }
        }

        /// <summary>
        /// Refills the AI player's hand from the deck.
        /// Before calling, check how many cards are in river
        /// </summary>
        private void RefillHandFromDeck(GameDeck deck)
        {
            int cardsToDraw = (getHand().length()) - 6;
            RefillHand(deck);
            
        }



    }
}
