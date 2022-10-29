namespace _03_PlayersDB.Interfaces
{
    internal interface IDataBase
    {
        int AddPlayer(IPlayer player);
        bool BanPlayer(int playerId);
        bool RemovePlayerBan(int playerId);
        IPlayer GetPlayer(int playerId);
        IPlayer RemovePlayer(int playerId);
        IEnumerable<IPlayer> GetPlayers();
    }
}
