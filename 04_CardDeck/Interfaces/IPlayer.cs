namespace _04_CardDeck.Interfaces
{
    internal interface IPlayer
    {
        void GetCard(ICardDeck cardDeck);
        void GetCards(ICardDeck cardDeck, int cardsCount);
    }
}
