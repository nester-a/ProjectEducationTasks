namespace _03_PlayersDB.Interfaces
{
    internal interface IDataBase
    {
        int AddPlayer(IPlayer player);//Пустые строки меж методами
        bool BanPlayer(int playerId);
        bool RemovePlayerBan(int playerId);//RemovePlayerFromBanList или лучше UnbanPlayer
        IPlayer GetPlayer(int playerId);
        IPlayer RemovePlayer(int playerId);
        IEnumerable<IPlayer> GetPlayers();
    }
}
