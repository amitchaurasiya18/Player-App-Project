using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppProject
{
    internal class Player
    {
        private readonly int _playerId;
        private readonly string _playerName;
        private readonly int _playerAge;
        public const int DEFAULT_AGE = 0;
        public static int maximumAge = DEFAULT_AGE;

        public Player(int playerId, string playerName) : this(playerId, playerName, DEFAULT_AGE)
        {
        }

        public Player(int playerId, string playerName, int playerAge)
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = playerAge;
        }

        public int GetPlayerId()
        {
            return _playerId;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }

        public int GetPlayerAge()
        {
            return _playerAge;
        }

        public Player ReturnWhoIsElder(Player[] players)
        {
            Player player1 = null;
            foreach (Player player in players)
            {
                if(player._playerAge > DEFAULT_AGE)
                {
                    maximumAge = player._playerAge;
                    player1 = player;
                }
            }

            return player1;
        }
    }
}
