namespace _04_CardDeck.Interfaces
{
    internal interface IPlayer
    {
        void GetCard(ICardDeck cardDeck);
        void GetCards(ICardDeck cardDeck, int cardsCount);
    }//А я если я захочу в любой момент времени посмотреть, что за карты на руках у игрока, что делать?
}
