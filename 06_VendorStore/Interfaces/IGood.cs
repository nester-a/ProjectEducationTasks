namespace _06_VendorStore.Interfaces
{
    internal interface IGood
    {
        string Name { get; }
        int Price { get; }

        bool Equals(object? obj);
        //Без указания этого метода в интерфейсе CLR не будет смотреть на переопределенный метод Equals в объекте класса Good,
        //при обращении к нему по сслыке интерфейса и будет использовать Object.Equals по умолчанию!
    }
}
