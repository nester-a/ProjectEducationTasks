namespace _04_CardDeck.Interfaces
{
    internal interface ICardDeck
    {
        ICard RemoveCard();
        IEnumerable<ICard> RemoveCards(int cardsCount);
    }
}
