using _04_CardDeck.Interfaces;

namespace _04_CardDeck.Entities
{
    internal class CardDeck : ICardDeck
    {   //Модификаторы полей нужно указывать явно - private Stack<ICard> _cards
        Stack<ICard> _cards = new();//Зачем тут стек? В некоторых карточных играх можно брать карты как сверху так и снизу.
                                    //Закрываешь себе вариант перетасовать колоду или  тянуть карты в закрытую из любой части колоды.

        public CardDeck(int cardsCount)//Чило карт должно сообтветствовать числу карт во Французской колоде(без джокеров). Оно постоянное - поэтому не должно передоваться извне.
        {
            if (cardsCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(cardsCount));

            for (int i = 0; i < cardsCount; i++)
            {
                _cards.Push(new Card());//Карты должны быть определенными.
            }//Можно инициализоровать колоду прямо в конструкторе, но её содержимое должно соответствовать Французской колоде.
            //Хотя по хорошему этим должен заниматься вообще отдельный класс - так как колода, это просто набор игральных карт, любых.
            //То есть это не ответственность колоды создавать свое содержимое.
        }

        public ICard RemoveCard()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("Card deck is empty");//Программа сломалась, а что дальше? Ее можно было и не ломать в этом месте...

            return _cards.Pop();
        }

        public IEnumerable<ICard> RemoveCards(int cardsCount)
        {
            if (_cards.Count < cardsCount)
                throw new InvalidOperationException("Cards is not enought");////Программа сломалась, а что дальше?

            var cards = new List<ICard>();

            for (int i = 0; i < cardsCount; i++)
            {
                cards.Add(_cards.Pop());
            }

            return cards;
        }
    }
}
