using _02_PropsWork.Interfaces;

namespace _02_PropsWork.Entities
{
    internal class Player : IPlayer
    {
        public int X { get; set; }

        public int Y { get; set; }
    }//Опционально было бы неплохо иметь 2 конструстора - один без параметров, другой на вход принимает х и y координаты.
}
