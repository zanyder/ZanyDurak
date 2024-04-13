/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: DurakGameForm, the main form in which the game is played
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Newtonsoft.Json;

namespace DurakClient
{
    public partial class DurakGameForm : Form
    {
        //initialize components of the form
        public DurakGameForm()
        {
            InitializeComponent();


            // Subscribe to events
            humanPlayer.InvalidAttackEvent += HandleInvalidAttack;
            humanPlayer.InvalidDefenseEvent += HandleInvalidDefense;
            aiPlayer2.NoOptionsEvent += HandleNoOptions;


        }

        private void HandleInvalidAttack(object sender, string message)
        {
            MessageBox.Show(message, "Invalid Attack", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleInvalidDefense(object sender, string message)
        {
            MessageBox.Show(message, "Invalid Defense", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleNoOptions(object sender, string message)
        {
            MessageBox.Show(message, "The AI has no Options to Play", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //declares all variables
        #region  Declaration of Variables and Game Reset     
        static 
        GameDeck myDeck = new GameDeck(ClientSettings.Instance.GameDeckSize);
        GameRiver myRiver = new GameRiver();
        //static string difficulty = ClientSettings.Instance.Difficulty;
        static PlayerHand myHandOne = new PlayerHand();
        static PlayerHand myHandTwo = new PlayerHand();


        Player humanPlayer = new Player(ClientSettings.Instance.PlayerName, myHandOne);
        PlayerAI aiPlayer2 = new PlayerAI("George");


        CardList DeckDisplayList = new CardList();

        CardList Hand1DisplayList = new CardList();
        CardList Hand2DisplayList = new CardList();


        CardList Player1DisplayList = new CardList();
        CardList Player2DisplayList = new CardList();

        CardList RiverDisplayList = new CardList();
        CardList trumpCardDisplayList = new CardList();
        CardList discardDisplayList = new CardList();
        GameLog GameLog = new GameLog();

        int deckSize = ClientSettings.Instance.GameDeckSize; // Get decksize from settings
        int roundNumber = 1;
        int playerOneWins = 0;
        int playerOneLosses = 0;
        int playerTwoWins = 0;
        int playerTwoLosses = 0;

        // Players Variables Setup
        // Player Name and Wins
        public static string playerName;
        public static int playerWinsDisplay;

        //public static int attacker = 0;
        static bool winFlag = false;

        //resets game
        public void InitializeGame()
        {
            // Reset View to default state
            // ViewDefault()

            CardImageControl _ = new CardImageControl();
            //flpDeck.Controls.Add(startingCardControl);
            myDeck = new GameDeck(ClientSettings.Instance.GameDeckSize);
            myRiver = new GameRiver();
            myHandOne = new PlayerHand();
            myHandTwo = new PlayerHand();

            DeckDisplayList = new CardList();
            Console.WriteLine("Created Cards");
            Hand1DisplayList = new CardList();
            Hand2DisplayList = new CardList();



            Player1DisplayList = new CardList();
            Player2DisplayList = new CardList();

            RiverDisplayList = new CardList();
            Console.WriteLine("Created DisplayLists");

            trumpCardDisplayList = new CardList();
            discardDisplayList = new CardList();
            Console.WriteLine("About to shuffle");
            myDeck.Shuffle(deckSize);
            Console.WriteLine("Shuffled deck");

            btnPickUp.Enabled = false;
            btnCeaseAttack.Enabled = true;

            lblHumanAttacking.Text = ClientSettings.Instance.PlayerName + " is attacking";
            lblPlayer2Attacking.Text = aiPlayer2.getName() + " is attacking";

            GameLog.Log("\nNEW GAME");
            GameLog.Log("\n PlayerOne Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
            GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");
        }
        #endregion


        //on form load reset game
        private void DurakClientForm_Load(object sender, EventArgs e)
        {
            InitializeGame();
            StartGame();

            // Access player name and Wins
            string playerName = ClientSettings.Instance.PlayerName;

            // Access AI Name
            string aiPlayerName = aiPlayer2.getName();

            // Filepath
            string filePath = @"../gamestats.json";

            // Find Player wins
            int playerWins = 0; // Default value if file or wins not found
            int aiPlayerWins = 0; // Default value if file or wins not found

            try
            {
                // Read the file content
                string statContent = File.ReadAllText(filePath);

                // Deserialize the JSON content into a list of Player objects
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(statContent);

                // Find the player by name
                Player player = players.FirstOrDefault(p => p.name == playerName);

                // If player found, retrieve their win count
                if (player != null)
                {
                    playerWins = player.winCount;
                }

                // Find the AI player by name
                Player aiPlayer = players.FirstOrDefault(p => p.name == aiPlayerName);

                // If AI player found, retrieve their win count
                if (aiPlayer != null)
                {
                    aiPlayerWins = aiPlayer.winCount;
                }
            }
                       
            catch (Exception ex)
            {
                // Handle file read error
                Console.WriteLine("Error reading game stats file: " + ex.Message);
            }

            // Concatenate it
            string playerInfo = playerName + "'s Wins: " + playerWins.ToString();
            // Concatenate AI player info
            string aiPlayerInfo = aiPlayerName + "'s Wins: " + aiPlayerWins.ToString();

            // Update Label
            labelPlayerInfo.Text = playerInfo;
            labelGeorgeInfo.Text = aiPlayerInfo;
        }

        private void StartGame()
        {
            // Set Trump Card          
            myDeck.setTrumpCard(myDeck);
            
            // Fill player hands
            humanPlayer.RefillHand(myDeck);
            aiPlayer2.RefillHand(myDeck);

            // DisplayAllCardLists
            DisplayAllCardLists();


            // Gameplay loop
        }

        public void DisplayAllCardLists()
        {
            DisplayPlayer1Cards();
            DisplayPlayer2Cards();


            DisplayRiverCards();

            //Update round number
            UpdateRoundNumber();
            DisplayTrumpCard();
            

        }


        public void DisplayTrumpCard()
        {
            flpTrumpCard.Controls.Clear();
            trumpCardDisplayList.Clear();

            for (int i = 0; i < 1; i++)
            {
                trumpCardDisplayList.Add(myDeck.getTrumpCard());
            }
            foreach (Card card in trumpCardDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpTrumpCard.Controls.Add(myCardControl);

            }
        }
        public void DisplayRiverCards()
        {
            //River Display Cards

            flpRiver.Controls.Clear();
            RiverDisplayList.Clear();

            for (int i = 0; i < myRiver.RiverCount(); i++)
            {
                RiverDisplayList.Add(myRiver.GetCard(i));
            }
            foreach (Card card in RiverDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpRiver.Controls.Add(myCardControl);
            }
        }

        public void DisplayPlayer1Cards()
        {
            flpHumanHand1.Controls.Clear();
            Player1DisplayList.Clear();

            for (int i = 0; i < humanPlayer.getHand().length(); i++)
            {
                Player1DisplayList.Add(humanPlayer.getHand().GetCard(i));
            }
            foreach (Card card in Player1DisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpHumanHand1.Controls.Add(myCardControl);

                //stores a card click event method for each card 
                myCardControl.CardClicked += new EventHandler(Card_Click);
            }
        }

        public void DisplayPlayer2Cards()
        {
            flpComputerHand2.Controls.Clear();
            Player2DisplayList.Clear();

            for (int i = 0; i < aiPlayer2.getHand().length(); i++)
            {
                Player2DisplayList.Add(aiPlayer2.getHand().GetCard(i));
            }
            foreach (Card card in Player2DisplayList)
            {
                CardImageControl startingCardControl = new CardImageControl();
                //myCardControl.Card = card;
                flpComputerHand2.Controls.Add(startingCardControl);
            }
        }

 
        // Update the round number 
        public void UpdateRoundNumber()
        {
            string boxValue = txtRoundNum.Text;
            // If no value, assume start of the game
            if (boxValue == "") { 
                
                txtRoundNum.Text = roundNumber.ToString();
            }
            else
            {
                // If there is a value, try to parse it
                if (int.TryParse(boxValue, out int rndNum))
                {
                  
                    txtRoundNum.Text = (rndNum+1).ToString();
                }
            }
        }

        public void Card_Click(object sender, EventArgs e)
        {
            CardImageControl clickedCardControl = new CardImageControl();

            clickedCardControl = (CardImageControl)sender;


            //checks to see if computer is defending if so human player attack phas starts and computer
            //defend phase begins
            if (aiPlayer2.IsAttacking != true)
            {
                humanPlayer.AttackingPhase(myRiver, (clickedCardControl.Card));

                aiPlayer2.DefendingPhase(myRiver, myDeck.getTrumpCard());


                //checks to see if computer is defending if not will log round in output file 
                //will reset round and have human start defending 
                if (aiPlayer2.IsAttacking != false)
                {
                    roundNumber += 1;

                    GameLog.LogRound(GameLog, roundNumber, humanPlayer, aiPlayer2, myRiver);
                    

                    for (int i = 0; i < myRiver.RiverCount(); i++)
                    {
                        myHandTwo.AddCardToHand(myRiver.GetCard(i));
                    }
                    myRiver.ClearRiver();
                    lblPlayer2Attacking.Visible = true;
                    lblHumanAttacking.Visible = false;
                    try
                    {
                        humanPlayer.RefillHand(myDeck);
                        aiPlayer2.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {

                    }

                    btnPickUp.Enabled = true;
                    btnCeaseAttack.Enabled = false;

                    aiPlayer2.AttackingPhase(myRiver);
                }
            }

            //human is defending, from computer attacks
            else
            {


                humanPlayer.DefendingPhase(myRiver, myDeck.getTrumpCard(), (clickedCardControl.Card));
                aiPlayer2.AttackingPhase(myRiver);

                //if human no longer defending, round over and reset, computer is now defending
                if (aiPlayer2.IsAttacking != true)
                {
                    roundNumber += 1;

                    GameLog.LogRound(GameLog, roundNumber, humanPlayer, aiPlayer2, myRiver);

                    if (!humanPlayer.defenseSuccess)
                    {
                        CardList cards = new CardList();
                        for (int j = 0; j < myRiver.RiverCount(); j++)
                        {
                            cards.Add(myRiver.GetCard(j));
                        }
                        humanPlayer.AddSelectCards(cards);
                    }

                    for (int i = 0; i < myRiver.RiverCount(); i++)
                    {
                        discardDisplayList.Add(myRiver.GetCard(i));
                    }
                    myRiver.ClearRiver();
                    lblPlayer2Attacking.Visible = false;
                    lblHumanAttacking.Visible = true;
                    try
                    {
                        humanPlayer.RefillHand(myDeck);
                        aiPlayer2.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {

                    }
                    btnPickUp.Enabled = false;
                    btnCeaseAttack.Enabled = true;
                }

            }



            DisplayAllCardLists();

            //logs who won the game and win/loss ratios
            if (humanPlayer.getHand().length() == 0)
            {
                GameStats gameStats = new GameStats();
                /*playerOneWins += 1;
                playerTwoLosses += 1;*/
                string winnerName = humanPlayer.getName();
                string loserName = aiPlayer2.getName(); 
                gameStats.logWinner(winnerName);
                gameStats.logLoser(loserName);
                MessageBox.Show("GAME OVER: PLAYER ONE HAS WON");
                /*GameLog.Log("\n*****GAME OVER: PLAYER ONE HAS WON***** \n");
                GameLog.Log("\n PlayerOne Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
                GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");*/
                InitializeGame();
            }

            if (aiPlayer2.getHand().length() == 0)
            {
                GameStats gameStats = new GameStats();
                /*playerTwoWins += 1;
                playerOneLosses += 1;*/
                string winnerName = aiPlayer2.getName();
                string loserName = humanPlayer.getName();
                gameStats.logWinner(winnerName);
                gameStats.logLoser(loserName);
                MessageBox.Show("GAME OVER: PLAYER TWO HAS WON");
                /*GameLog.Log("\n*****GAME OVER: PLAYER TWO HAS WON***** \n");
                GameLog.Log("\n PlayerOne Win/Loss Ratio " + playerOneWins.ToString() + "/" + playerOneLosses.ToString());
                GameLog.Log("\n PlayerTwo Win/Loss Ratio " + playerTwoWins.ToString() + "/" + playerTwoLosses.ToString() + "\n");*/
                InitializeGame();
            }
        }
        


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRoundNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCeaseAttack_Click(object sender, EventArgs e)
        {
            roundNumber += 1;

            GameLog.LogRound(GameLog, roundNumber, humanPlayer, aiPlayer2, myRiver);

            if (!aiPlayer2.defenseSuccess && myRiver.RiverCount() % 2 != 0)
            {
                for (int i = 0; i < myRiver.RiverCount(); i++)
                {
                    aiPlayer2.getHand().AddCardToHand(myRiver.GetCard(i));
                }
                myRiver.ClearRiver();
            }
            else
            {
                myRiver.ClearRiver();
            }

            try
            {
                humanPlayer.RefillHand(myDeck);
                aiPlayer2.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }
            //myPlayerOne.setIsAttacking(false);
            //myPlayerOne.setIsDefending(true);
            //myPlayerTwo.setIsAttacking(true);
            aiPlayer2.IsAttacking = true;

            lblPlayer2Attacking.Visible = true;
            lblHumanAttacking.Visible = false;

            btnPickUp.Enabled = true;
            btnCeaseAttack.Enabled = false;

            aiPlayer2.AttackingPhase(myRiver);

            DisplayAllCardLists();
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            roundNumber += 1;

            GameLog.LogRound(GameLog, roundNumber, humanPlayer, aiPlayer2, myRiver);
            for (int i = 0; i < myRiver.RiverCount(); i++)
            {
                humanPlayer.getHand().AddCardToHand(myRiver.GetCard(i));
            }
            myRiver.ClearRiver();
            
            try
            {


                humanPlayer.RefillHand(myDeck);
                aiPlayer2.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }

            aiPlayer2.IsAttacking = false;


            lblPlayer2Attacking.Visible = false;
            lblHumanAttacking.Visible = true;

            btnPickUp.Enabled = false;
            btnCeaseAttack.Enabled = true;

            DisplayAllCardLists();
        }
    }
}
