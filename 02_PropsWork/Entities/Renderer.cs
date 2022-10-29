using _02_PropsWork.Interfaces;

namespace _02_PropsWork.Entities
{
    internal class Renderer : IRenderer
    {
        public void Render(IPlayer player)
        {
            Console.WriteLine($"Render palyer on [{player.X}:{player.Y}]");
        }
    }
}
