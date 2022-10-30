namespace _03_PlayersDB.Interfaces
{
    internal interface IPlayer//Это очень странно. Часть свойств можно задачать через set - часть нет, логики никакой я в этом не вижу.
    {
        int Id { get; set; }//Пустые строки меж методами
        string Name { get; }
        int Level { get; }
        bool IsBanned { get; set; }
    }
}
