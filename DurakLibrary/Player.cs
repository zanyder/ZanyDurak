/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: DurakGameForm, the main form in which the game is played
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    /// <summary>
    /// Represents a player in the game, providing functionality for gameplay.
    /// </summary>
    public class Player
    {
        //instance attributes
        public String name = "";
        private PlayerHand hand = new PlayerHand();
        private bool isAttacking = false;
        public int winCount = 0;
        public int lossCount = 0;
        public double ratio = 0.0;
        //public double ratio = 100*(winCount/lossCount);
        public double winStreak = 0;
        public bool isOnStreak = false;
        public bool defenseSuccess = false;
        

        //class attributes
        public const String DEFAULT_NAME = "Johnny B Goode";
        public const PlayerHand DEFAULT_PLAYERHAND = null;
        public const bool DEFAULT_ISATTACKING = false;

        // Invalid Attacl Handlers
        public event EventHandler<string> InvalidAttackEvent;
        public event EventHandler<string> InvalidDefenseEvent;

        //default constructor
        public Player()
        {
            // CHANGE THIS TO TAKE THE INPUT FROM PLAYER
            setName(DEFAULT_NAME);
            
            
        }

        //parameterized constructor(PlayerHand hand)
        public Player(String name, PlayerHand hand)
        {
            setName(name);    
            setHand(hand);
        }

        //Attacking phase for human players
        public virtual void AttackingPhase(GameRiver gameRiver, Card attackingCard)
        {

            CardList gameRiverList = new CardList();
 

            for (int i = 0; i < gameRiver.RiverCount(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }


            switch (gameRiver.RiverCount())
            {
                case 0:


                    gameRiver.AddCardToRiver(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);
     
                    break;

                case 2:
                    if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                    }
                    else
                    {
                        InvalidAttackEvent?.Invoke(this, "Invalid Attack: You can only attack with a card of the same rank as one of the cards in the river.");
                    }
                    break;

                case 4:
                    if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);
                    break;
                    }
                    break;

                case 6:
                    if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank | attackingCard.GetCardRank() == gameRiverList[4].rank | attackingCard.GetCardRank() == gameRiverList[5].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);
                    break;
                    }
                    break;

                case 8:
                    if (attackingCard.GetCardRank() == gameRiverList[0].rank | attackingCard.GetCardRank() == gameRiverList[1].rank | attackingCard.GetCardRank() == gameRiverList[2].rank | attackingCard.GetCardRank() == gameRiverList[3].rank | attackingCard.GetCardRank() == gameRiverList[4].rank | attackingCard.GetCardRank() == gameRiverList[5].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);
                    break;
                    }
                    break;
            }



        }

        //Defending phase for human players
        public virtual void DefendingPhase(GameRiver gameRiver, Card trumpCard, Card defendingCard)
        {
            //Card defendingCard = new Card();
            CardList gameRiverList = new CardList();
            bool sucessfulldefense = false;

            for (int i = 0; i < gameRiver.RiverCount(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }



            switch (gameRiver.RiverCount())
            {
                case 1:


                    if (defendingCard.GetCardSuit() == gameRiverList[0].suit & defendingCard > gameRiverList[0] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[0])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        defenseSuccess = true;
                        
                    }
                    else
                    {
                        InvalidDefenseEvent?.Invoke(this, "Invalid Defense: You must play a card of higher rank and the same suit or a trump card to defend against the attack.");
                    }
                    break;

                case 3:


                    if (defendingCard.GetCardSuit() == gameRiverList[2].suit & defendingCard > gameRiverList[2] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[2])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        defenseSuccess = true;
                        break;
                    }
                    break;


                case 5:


                    if (defendingCard.GetCardSuit() == gameRiverList[4].suit & defendingCard > gameRiverList[4] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[4])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        defenseSuccess = true;
                        break;
                    }
                    break;

                case 7:


                    if (defendingCard.GetCardSuit() == gameRiverList[6].suit & defendingCard > gameRiverList[6] | defendingCard.GetCardSuit() == trumpCard.GetCardSuit() & defendingCard > gameRiverList[6])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        defenseSuccess = true;
                        break;
                    }
                    break;
            }
        }


        //will refill player hand
        public void RefillHand(GameDeck deck)
        {

            CardList cards=deck.DrawCards(6-hand.length());
                hand.AddCardsToHand(cards);

        }

        // Will refill player hand with sent list of cards
        public void AddSelectCards(CardList cards)
        {
                hand.AddCardsToHand(cards);
        }


        //getters and setters
        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public PlayerHand getHand()
        {
            return hand;
        }

        public void setHand(PlayerHand hand)
        {
            this.hand = hand;
        }

        public bool getIsAttacking()
        {
            return isAttacking;
        }

        public void setIsAttacking(bool isAttacking)
        {
            this.isAttacking = isAttacking;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
