using _04_CardDeck.Interfaces;

namespace _04_CardDeck.Entities
{
    internal class Player : IPlayer
    {
        List<ICard> _cards = new();

        public void GetCard(ICardDeck cardDeck)
        {
            var card = cardDeck.RemoveCard();
            _cards.Add(card);

            Console.WriteLine($"Player gets {card}");
        }

        public void GetCards(ICardDeck cardDeck, int cardsCount)
        {
            var cards = cardDeck.RemoveCards(cardsCount);
            _cards.AddRange(cards);

            Console.WriteLine($"Player gets next cards: ");
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
