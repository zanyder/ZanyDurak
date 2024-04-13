/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/04/04
 Description: GameLog class, This is where all game log activities will
 commence.   
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DurakLibrary
{
    // Represents a game log for recording and managing game-related messages and statistics.
    public class GameLog
    {
        //the log can be found in DurakLibrary/bin Folder as gamelog.txt
        public string filepath = @"../gamelog.txt";

        // Appends the specified message to the game log file.
        public void Log(string message)
        {
            StreamWriter streamWriter = File.AppendText(filepath);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }

        // Clears the game log file and writes the specified message.
        public void ClearLog(string message)
        {
            StreamWriter streamWriter = new StreamWriter(filepath);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }

        // Logs the statistics and details of a game round.
        public void LogRound(GameLog gameLog, int roundNumber, Player playerOne, Player playerTwo, GameRiver gameRiver)
        {
            gameLog.Log("\nDATE: " + DateTime.Now +
                        "\nROUND: " + roundNumber.ToString() +
                        "\n\t" + playerOne.ToString() +
                        "\n\n\t" + playerTwo.ToString() +
                        gameRiver.ToString(gameRiver));
        }

        // Logs the results of a completed match. Called after 
        // a winning game condition is found by at least 1 player. 
        public void LogMatch(GameLog matchLog, int matchNumber, Player winningPlayer, Player losingPlayer, GameRiver gameRiver)
        {
            matchLog.Log("\nDATE: " + DateTime.Now +
                         "\nMATCH: " + matchNumber.ToString() +
                         "\nWINNER: " + winningPlayer.ToString() +
                         "\nLOSER: " + losingPlayer.ToString() +
                         "\nEND STATE: " + gameRiver.ToString(gameRiver));
        }

    }
}