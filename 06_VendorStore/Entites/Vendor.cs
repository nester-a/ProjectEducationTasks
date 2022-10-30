using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class Vendor : IVendor
    {
        List<IGood> _goods = new();//private

        public Vendor(GoodsSeeder seeder)//Сюда лучше передавать уже полученный перечень товаров.
        {
            seeder.SeedData(_goods);
        }

        public IEnumerable<IGood> ShowGoods()
        {
            return _goods;
        }

        public IGood? TryTrade(IGood goodForSale, IPlayer bueyer)
        //Cтоить изменить тип возвращаемого значения на bool - тогда не придется делать проверку на возвратившийся null.
        //Если спрошенный товар есть и бабок хватает - то вернем true, иначе false.
        //А какой товар мы получим - в случае успеха уже описано в goodForSale.
        {
            var good = _goods.FirstOrDefault(g => g.Equals(goodForSale));
            //В таких проверках нужно внимательно следить, чтобы Equals был корректно переопределен (и вызвался!).
            //Если его никто не переопределял, и сравниваются клонированные копии объектов через Object.Equals - то проверка будет неккоректной - на выходе всегда будет false.

            if (good is null)
                return null;//Возврат null это не хорошая тема.

            var dealCanBeDone = bueyer.CanPayCoins(goodForSale.Price);
            if (!dealCanBeDone)
                return null;

            var paid = bueyer.PayCoins(goodForSale.Price);//Вот эти деньги упали просто на пол и пропали. А они должны были оказаться на балансе магазина.
            //Товар стоил 7 монет - а покупатель заплатил 93... как это?

            return good;
        }
    }
}
