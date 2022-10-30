using _03_PlayersDB.Interfaces;

namespace _03_PlayersDB.Entities
{
    internal class Player : IPlayer//Это Dto или нет? Учитывая неразбериху в интерфейсе, наверное, нет. Тогда тут поля должны быть неизменяемыми, как и весь объект
                                   // https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%B8%D0%B7%D0%BC%D0%B5%D0%BD%D1%8F%D0%B5%D0%BC%D1%8B%D0%B9_%D0%BE%D0%B1%D1%8A%D0%B5%D0%BA%D1%82
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }

        public bool IsBanned { get; set; } = false;
    }
}
