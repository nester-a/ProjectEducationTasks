using _03_PlayersDB.Interfaces;

namespace _03_PlayersDB.Entities
{
    internal class DataBase : IDataBase
    {
        List<IPlayer> _players = new();
        public int AddPlayer(IPlayer player)
        {
            int id = _players.Count + 1;
            player.Id = id;
            _players.Add(player);

            return id;
        }

        public bool BanPlayer(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                return false;

            player.IsBanned = true;
            return true;
        }

        public IPlayer GetPlayer(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                throw new ArgumentException("Player with this Id not found");

            return player;
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            return _players;
        }

        public IPlayer RemovePlayer(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                throw new ArgumentException("Player with this Id not found");

            _players.Remove(player);

            return player;
        }

        public bool RemovePlayerBan(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                return false;

            player.IsBanned = false;
            return true;
        }
    }
}
