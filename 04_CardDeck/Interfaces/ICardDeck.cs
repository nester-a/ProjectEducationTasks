namespace _04_CardDeck.Interfaces
{
    internal interface ICardDeck
    {
        ICard RemoveCard();//Я бы заменил слово Remove на что то другое - мы же не выбрасываем эти карты в мусорку?
        IEnumerable<ICard> RemoveCards(int cardsCount);
    }
}
