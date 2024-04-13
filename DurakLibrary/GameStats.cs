/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/18
 Revision Date: 2024/04/04
 Description: GameStats class, where all statistics on win/loss and 
 player history are managed in a flat file. 
 The data is retrieved and read, then updated according to the results
 of the finishing game, then rewritten with the updated stats. 
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace DurakLibrary
{

    public class GameStats 
    {
        // The stats can be found in DurakClient Folder as gamestats.json
        public string filepath = @"../gamestats.json";

        // Increment the winners stats
        public void logWinner(string playerName)
        {
            // Read the file to check for players
            string statContent = File.ReadAllText(filepath);

            // Deserialize the data into a list of JSON objects
            List<Player> players = new List<Player>();

            try {

                // Deserialize the data into a list of JSON objects
                List<Player> existingPlayers = JsonConvert.DeserializeObject<List<Player>>(statContent);

                // Try to find the winning player
                Player winningPlayer = players.FirstOrDefault(player => player.name == playerName);

                if (winningPlayer != null)
                {
                    // Increment and recalculate their stats
                    winningPlayer.winCount += 1;
                    winningPlayer.ratio = winningPlayer.lossCount == 0 ? 100 : 100 * (float)winningPlayer.winCount / (winningPlayer.winCount + winningPlayer.lossCount);
                    if (winningPlayer.isOnStreak)
                    {
                        winningPlayer.winStreak += 1;
                    }
                    else
                    {
                        winningPlayer.isOnStreak = true;
                        winningPlayer.winStreak = 1;
                    }
                    // Serialize and write the updated list back to the file
                    string changedContent = JsonConvert.SerializeObject(players);
                    File.WriteAllText(filepath, changedContent);
                }
            } catch (Exception e) {
                    // If player not found, add new player
                    Player winningPlayer = new Player
                    {
                        name = playerName,
                        winCount = 1,
                        lossCount = 0,
                        winStreak = 1,
                        isOnStreak = true,
                        ratio = 100
                    };
                    // add the new player 
                    players.Add(winningPlayer);
            }

            // Serialize and write the updated list back to the file
            string updatedContent = JsonConvert.SerializeObject(players);
            File.WriteAllText(filepath, updatedContent);
        }

        // Decrement the losers stats 
        public void logLoser(string playerName)
        {
            // Read the file to check for players
            using (StreamReader reader = new StreamReader(filepath))
            {
                string statContent = reader.ReadToEnd();

                // Deserialize the data into a list of JSON objects
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(statContent);

                // Find the index of the losing player
                int indexToUpdate = players.FindIndex(player => player.name == playerName);

                if (indexToUpdate != -1)
                { // Ensure the player was found
                    Player losingPlayer = players[indexToUpdate];

                    // Increment their loss count
                    losingPlayer.lossCount += 1;

                    // Update the ratio. Avoid division by zero by checking loss count.
                    if (losingPlayer.lossCount > 0)
                    {
                        losingPlayer.ratio = losingPlayer.winCount == 0 ? 0 : (float)losingPlayer.winCount / losingPlayer.lossCount;
                    }

                    // End any win streak they were on
                    if (losingPlayer.isOnStreak)
                    {
                        losingPlayer.winStreak = 0;
                        losingPlayer.isOnStreak = false;
                    }

                    // Serialize the updated player object back to JSON and update the list
                    players[indexToUpdate] = losingPlayer;

                    // Write the updated list back to the file
                    string updatedContent = JsonConvert.SerializeObject(players);
                    File.WriteAllText(filepath, updatedContent);
                }
            }
        }

        // Retrieve a list of all player stats.
        public List<Player> RetrieveAllPlayers()
        {
            // read the full file
            string statContent = File.ReadAllText(filepath);

            // Deserialize the JSON content into a list of Player objects
            var players = JsonConvert.DeserializeObject<List<Player>>(statContent);

            // Return the list of players
            return players;
        }

        // Retrieve a player by name and clear their stats 
        public void ClearStats(string playerName)
        {
            // Read the file to check for players
            string statContent = File.ReadAllText(filepath);

            // Deserialize the data into a list of Player objects
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(statContent);

            // Find the index of the player to clear
            int indexToUpdate = players.FindIndex(player => player.name == playerName);

            // Check if the player exists in the list
            if (indexToUpdate != -1)
            {
                // Clear the stats of the player
                Player clearingPlayer = players[indexToUpdate];
                clearingPlayer.winCount = 0;
                clearingPlayer.lossCount = 0;
                clearingPlayer.winStreak = 0;
                clearingPlayer.ratio = 0.0;
                clearingPlayer.isOnStreak = false;

                // Update the player in the list
                players[indexToUpdate] = clearingPlayer;

                // Serialize and write the updated list back to the file
                string updatedContent = JsonConvert.SerializeObject(players);
                File.WriteAllText(filepath, updatedContent);
            }
        }
    }

}
