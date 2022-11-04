using System.Text;

namespace Services{

    public class Cell{
        public string Value { get; private set; } = string.Empty;

        public ConsoleColor ValueColor { get; private set; } = ConsoleColor.White;

        //вместимость клетки
        int _capacity = 15;


        public Cell(string value)
        {
            SetValue(value);
        }

        public Cell(string value, ConsoleColor color)
        {
            SetValue(value);

            ValueColor = color;
        }
    
        private void SetValue(string value)
        {
            if(value == "\t" || value == "\n")
            {
                Value = value;
                return;
            }
            if(value.Length > _capacity)
            {
                Value = value.Substring(0, 10);
            }
            else if(value.Length < _capacity)
            {
                var whiteSpaces = _capacity - value.Length;

                var sb = new StringBuilder();

                sb.Append(value);

                for (int i = 0; i < whiteSpaces; i++)
                {
                    sb.Append(" ");
                }

                Value = sb.ToString();
            }
            else
            {
                Value = value;
            }
        }
    }
}