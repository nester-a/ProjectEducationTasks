using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class Player : IPlayer
    {
        public int CoinsBag { get; private set; }

        List<IGood> _backPack = new();

        public Player(int coinsInBag)
        {
            CoinsBag = coinsInBag;
        }


        public void BuyGoods(IVendor vendor, params IGood[] goods)
        {
            if (!goods.Any())
            {
                Console.WriteLine("Nothing to buy");
                return;
            }

            foreach (var item in goods)
            {
                Console.WriteLine($"Try buy {item} from vendor");
                var dealResult = vendor.TryTrade(item, this);
                if (dealResult is null)
                {
                    Console.WriteLine($"Cant buy {item}");
                }
                else
                {
                    Console.WriteLine($"{item} buyed");
                    _backPack.Add(dealResult);
                }
                Console.WriteLine("Ending trade");
            }
        }

        public void BuyGoods(IVendor vendor, IEnumerable<IGood> goods)
        {
            if (!goods.Any())
            {
                Console.WriteLine("Nothing to buy");
                return;
            }

            foreach (var item in goods)
            {
                Console.WriteLine($"Try buy {item} from vendor");
                var dealResult = vendor.TryTrade(item, this);
                if (dealResult is null)
                {
                    Console.WriteLine($"Cant buy {item}");
                }
                else
                {
                    Console.WriteLine($"{item} buyed");
                    _backPack.Add(dealResult);
                }
                Console.WriteLine("Ending trade");
            }
        }

        public bool CanPayCoins(int coinsCount)
        {
            return CoinsBag >= coinsCount;
        }

        public void LookVendorsGoods(IVendor vendor)
        {
            var goods = vendor.ShowGoods();
            if(!goods.Any())
            {
                Console.WriteLine("Vendor has no any goods");
                return;
            }
            Console.WriteLine("So vendor has:");
            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }
        }

        public int PayCoins(int coinsCount)
        {
            return CoinsBag -= coinsCount;
        }

        public void LookBackPack()
        {
            if (!_backPack.Any())
            {
                Console.WriteLine("Backpack has no any goods");
                return;
            }

            Console.WriteLine("In backpack:");
            foreach (var item in _backPack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
