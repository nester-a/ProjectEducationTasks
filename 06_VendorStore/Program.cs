using _06_VendorStore.Entites;

var seeder = new GoodsSeeder(10);
var vendor = new Vendor(seeder);
var player = new Player(100);

Console.WriteLine("Player came into vendors store");
Console.WriteLine();
player.LookVendorsGoods(vendor);
Console.WriteLine();
var goods = vendor.ShowGoods();
var ordered = goods.OrderBy(g => g.Price).ToList();

player.BuyGoods(vendor, ordered);
Console.WriteLine();
Console.WriteLine("Player moves out from vendors store");
Console.WriteLine("Work ends");
Console.ReadLine();
