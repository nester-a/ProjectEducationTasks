using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class GoodsSeeder
    {
        private readonly int _howManySeed;

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
        public GoodsSeeder(int howManySeed)
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
            var rnd = new Random();
            var name = _names[rnd.Next(0, _names.Length)];
            var price = rnd.Next(5, 40);

            return new Good(name, price);
        }
    }
}
