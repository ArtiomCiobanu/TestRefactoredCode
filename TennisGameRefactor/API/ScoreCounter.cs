using System.Collections.Generic;

namespace TennisGameRefactor.API
{
    public class ScoreCounter
    {
        private Dictionary<string, Player> Players { get; }

        public ScoreCounter(Dictionary<string, Player> players)
        {
            Players = players;
        }

        public void IncreasePlayerScore(string playerName)
        {
            Players[playerName].Score++;
        }
    }
}