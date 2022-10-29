using _03_PlayersDB.Interfaces;

namespace _03_PlayersDB.Entities
{
    internal class Player : IPlayer
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }

        public bool IsBanned { get; set; } = false;
    }
}
