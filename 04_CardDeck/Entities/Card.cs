using _04_CardDeck.Interfaces;

namespace _04_CardDeck.Entities
{
    internal class Card : ICard
    {
        public int CardNumder { get; }//private set; лучше указывать явно.

        public int CardSuit { get; }//Заменить int на значение enum PlayingCardSuitTypes

        public Card()//Карта не может сама себя создавать - она лишь хранит в себе информацию об масти и её номере (весе/значении).
        {
            var rnd = new Random();//Почему тут вообще Random? В колоде хранятся вполне себе определенные карты.
            //Можно взять за пример Французскую колоду (без джокеров). https://ru.wikipedia.org/wiki/%D0%A4%D1%80%D0%B0%D0%BD%D1%86%D1%83%D0%B7%D1%81%D0%BA%D0%B0%D1%8F_%D0%BA%D0%BE%D0%BB%D0%BE%D0%B4%D0%B0
            CardNumder = rnd.Next(1, 7);
            CardSuit = rnd.Next(1, 5);
        }

        public override string ToString()
        //Переопределение ToString() немного неоднозначная штука. 
        //У меня среда VS показывает, что сюда ничего не ссылается.
        //То есть я потом по ссылкам этот метод найти не смогу.
        //Я бы лучше этот метод назвал GetInfo(), чтобы его явно дергать руками.
        //Вот программист набрал переменную сard, нажал точку и сидит гадает, как ему инфу вывести - не находит...
        //И дальше либо руками код пишет для отображения - например создает класс CardInfoPrinter или еще чего.
        //Есть вариант, что он так и не зайдет в код класса, тем более, что в интерфейсе упоминания этого метода нету.
        {
            return $"Card: Suit-{CardSuit}, Number-{CardNumder}";//
        }
    }
}
