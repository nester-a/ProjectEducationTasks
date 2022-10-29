namespace _06_VendorStore.Interfaces
{
    internal interface IVendor
    {
        IGood? TryTrade(IGood goodForSale, IPlayer bueyer);
        IEnumerable<IGood> ShowGoods();
    }
}
