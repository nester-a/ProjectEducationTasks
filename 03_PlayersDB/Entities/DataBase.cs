using _03_PlayersDB.Interfaces;

namespace _03_PlayersDB.Entities
{
    internal class DataBase : IDataBase
    {
        List<IPlayer> _players = new();//Офтоп - не люблю этот новый "сахар" new() в языке
        public int AddPlayer(IPlayer player)
        {
            int id = _players.Count + 1;//Тут косяк,
                                        //добавляешь 3х игроков id: 1, 2, 3.
                                        //Удаляешь 2го id: 1, 3.
                                        //Добавлешь еще 1го id: 1, 3, 3.
                                        // У тебя коллизия в поле id 3 и 3. Такого быть не должно!
            player.Id = id;
            _players.Add(player);

            return id;
        }

        public bool BanPlayer(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                return false;
                //Моя личная просьба - выражения из одного оператора оборачивать в фигурные скобки. Например:
                //{
                //    return false;
                //}
                //Так проще читать.

            player.IsBanned = true;
            return true;
        }

        public IPlayer GetPlayer(int playerId)
        {
            var player = _players.FirstOrDefault(p => p.Id == playerId);
            if (player is null)
                throw new ArgumentException("Player with this Id not found");//Тут программа сломалась - а что делать дальше?

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
