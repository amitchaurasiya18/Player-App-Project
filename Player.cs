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
        public int maximumAge = DEFAULT_AGE;

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

        public void ReturnWhoIsElder(Player[] players, out int elderPlayerId, out string elderPlayerName, out int elderPlayerAge)
        {
            Player elderPlayer = null;
            foreach (Player player in players)
            {
                elderPlayer = (elderPlayer == null || player._playerAge > elderPlayer._playerAge) ? player : elderPlayer;
            }

            elderPlayerId = elderPlayer != null ? elderPlayer._playerId : 0;
            elderPlayerName = elderPlayer != null ? elderPlayer._playerName : "No Player";
            elderPlayerAge = elderPlayer != null ? elderPlayer._playerAge : DEFAULT_AGE;
            
        }
    }
}
