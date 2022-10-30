namespace _02_PropsWork.Interfaces
{
    internal interface IPlayer //Не до конца отражена суть в имени интерфейса. Этот позволяет только прочитать данные - IReadOnlyPlayer в названии лучше отражает суть интерфейса.
    {
        int X { get; }
        int Y { get; }//Разделять методы и своиства в интерфейсе пустыми строчками.
    }
}
