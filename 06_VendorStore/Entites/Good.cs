using _06_VendorStore.Interfaces;

namespace _06_VendorStore.Entites
{
    internal class Good : IGood
    {
        public string Name { get; }

        public int Price { get; }

        public Good(string name, int price)
        {
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price));
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} for {Price} coins";
        }

        public override bool Equals(object? obj)//Сюда не вела ни одна ссылка! Она стала действительной при объявлении Equals в интерфейсе.
        {
            if (obj is null || obj is not IGood)
                return false;
            
            var good = obj as IGood;

            var equals = good!.Name.Equals(Name) && good.Price == Price;
            //
            //https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/null-forgiving
            //good! - немного избыточно, так как выше проверка if (obj is null || obj is not IGood) return false;

            if (equals)
            {
                int insertDebugPointHere = 1;
            }

            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
