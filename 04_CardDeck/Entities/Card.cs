using _04_CardDeck.Interfaces;

namespace _04_CardDeck.Entities
{
    internal class Card : ICard
    {
        public int CardNumder { get; }

        public int CardSuit { get; }

        public Card()
        {
            var rnd = new Random();
            CardNumder = rnd.Next(1, 7);
            CardSuit = rnd.Next(1, 5);
        }

        public override string ToString()
        {
            return $"Card: Suit-{CardSuit}, Number-{CardNumder}";
        }
    }
}
