namespace Services
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IPrintInfo infoObj)
        {
            var cells = infoObj.GetInfo();
            foreach (var cell in cells)
            {
                Console.ForegroundColor = cell.ValueColor;
                Console.Write(cell.Value);
                Console.ResetColor();
            }
        }
    }
}
