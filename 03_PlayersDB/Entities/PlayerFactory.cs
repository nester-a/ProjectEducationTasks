using _03_PlayersDB.Interfaces;

namespace _03_PlayersDB.Entities
{
    internal class PlayerFactory
    {
        private int _count = 0;

        public IPlayer CreatePlayer()
        {
            var player = new Player();

            var rnd = new Random();

            player.Name = string.Concat("Player", ++_count);

            player.Level = rnd.Next(1, 81);

            return player;
        }

        public IEnumerable<IPlayer> CreatePlayers(int playersCount)
        {
            var res = new List<IPlayer>();

            if(playersCount <= 0)
            {
                return Enumerable.Empty<IPlayer>();
            }

            for (int i = 0; i < playersCount; i++)
            {
                res.Add(CreatePlayer());
            }

            return res;
        }
    }
}

