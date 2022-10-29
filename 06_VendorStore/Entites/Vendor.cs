using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class Vendor : IVendor
    {
        List<IGood> _goods = new();

        public Vendor(GoodsSeeder seeder)
        {
            seeder.SeedData(_goods);
        }

        public IEnumerable<IGood> ShowGoods()
        {
            return _goods;
        }

        public IGood? TryTrade(IGood goodForSale, IPlayer bueyer)
        {
            var good = _goods.FirstOrDefault(g => g.Equals(goodForSale));

            if(good is null)
                return null;

            var dealCanBeDone = bueyer.CanPayCoins(goodForSale.Price);
            if (!dealCanBeDone)
                return null;

            bueyer.PayCoins(goodForSale.Price);

            return good;
        }
    }
}
