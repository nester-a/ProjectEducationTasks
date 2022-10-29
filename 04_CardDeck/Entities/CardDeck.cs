using _04_CardDeck.Interfaces;

namespace _04_CardDeck.Entities
{
    internal class CardDeck : ICardDeck
    {
        Stack<ICard> _cards = new();

        public CardDeck(int cardsCount)
        {
            if (cardsCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(cardsCount));

            for (int i = 0; i < cardsCount; i++)
            {
                _cards.Push(new Card());
            }
        }

        public ICard RemoveCard()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("Card deck is empty");

            return _cards.Pop();
        }

        public IEnumerable<ICard> RemoveCards(int cardsCount)
        {
            if (_cards.Count < cardsCount)
                throw new InvalidOperationException("Cards is not enought");

            var cards = new List<ICard>();

            for (int i = 0; i < cardsCount; i++)
            {
                cards.Add(_cards.Pop());
            }

            return cards;
        }
    }
}
