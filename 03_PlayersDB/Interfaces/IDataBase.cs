namespace _03_PlayersDB.Interfaces
{
    internal interface IDataBase
    {
        int AddPlayer(IPlayer player);

        int AddPlayers(IEnumerable<IPlayer> players);
        
        bool BanPlayer(int playerId);

        bool UnbanPlayer(int playerId);
        
        IPlayer? GetPlayer(int playerId);

        IPlayer? RemovePlayer(int playerId);
        
        IEnumerable<IPlayer> GetPlayers();
    }
}
