namespace _06_VendorStore.Interfaces
{
    internal interface IPlayer
    {
        int CoinsBag { get; }
        void LookVendorsGoods(IVendor vendor);
        void LookBackPack();//Это название ничего конкретного не отражает. Лучше Show BackPack Content или ShowItems
        void BuyGoods(IVendor vendor, params IGood[] goods);
        void BuyGoods(IVendor vendor, IEnumerable<IGood> goods);
        bool CanPayCoins(int coinsCount);
        int PayCoins(int coinsCount);
    }
}
