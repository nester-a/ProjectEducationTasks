using System;

namespace Services
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IPrintInfo infoObj)
        {
            Console.WriteLine("Программа выполнена");
        }
    }
}
