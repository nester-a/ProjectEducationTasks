using _03_PlayersDB.Interfaces;
using Services;
using System.Text;

namespace _03_PlayersDB.Entities
{
    internal class DataBase : IDataBase, IPrintInfo
    {
        private List<IPlayer> _players = new List<IPlayer>();

        private int _currentId = 0;

        public int AddPlayer(IPlayer player)
        {                    
            player.Id = ++_currentId;

            _players.Add(player);

            return _currentId;
        }

        public int AddPlayers(IEnumerable<IPlayer> players)
        {
            if(!players.Any())
            {
                return 0;
            }

            foreach (var player in players)
            {
                AddPlayer(player);
            }

            return players.Count();
        }

        public bool BanPlayer(int playerId)
        {
            var player = GetPlayer(playerId);

            if (player is null)
            {
                return false;
            }

            player.IsBanned = true;

            return true;
        }

        public IPlayer? GetPlayer(int playerId)
        {
            return _players.FirstOrDefault(p => p.Id == playerId);
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            return _players;
        }

        public IPlayer? RemovePlayer(int playerId)
        {
            var player = GetPlayer(playerId);

            if (player is null)
            {
                return player;
            }

            _players.Remove(player);

            return player;
        }

        public bool UnbanPlayer(int playerId)
        {
            var player = GetPlayer(playerId);

            if (player is null)
            {
                return false;
            }

            player.IsBanned = false;

            return true;
        }
        public IEnumerable<Cell> GetInfo()
        {
            var cells = new List<Cell>(){
                new Cell("ID", ConsoleColor.DarkBlue),
                new Cell("NAME", ConsoleColor.DarkBlue),
                new Cell("LEVEL", ConsoleColor.DarkBlue),
                new Cell("BANNED", ConsoleColor.DarkBlue),
                new Cell("\n")
            };

            foreach (var player in _players)
            {
                cells.AddRange(player.GetInfo());
                cells.Add(new Cell("\n"));
            }

            return cells;
        }
    }
}
