using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class GoodsSeeder
    {
        private readonly int _howManySeed;//Почему оно заблокировано для изменения?
        //А если оно генерирует разное кол-во товаров каждый раз - для каждого случая отдельный объект создавать заново?

        string[] _names = new string[]
        {
            "Топор",
            "Меч",
            "Щит",
            "Консервы",
            "Обувь",
            "Амулет",
            "Флейта"
        };
        public GoodsSeeder(int howManySeed)//Почему оно передается в конструктор.
        {
            if(howManySeed <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(howManySeed));
            }
            _howManySeed = howManySeed;
        }

        public void SeedData(List<IGood> goods)
        {
            for (int i = 0; i < _howManySeed; i++)
            {
                goods.Add(GetRandomGood());
            }
        }

        private IGood GetRandomGood()
        {
            var rnd = new Random();//см. предыдущие задачи.
            var name = _names[rnd.Next(0, _names.Length)];
            var price = rnd.Next(5, 40);

            return new Good(name, price);
        }
    }
}
