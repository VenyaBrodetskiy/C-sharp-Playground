namespace MultiplicationBoard
{
    internal class MultiBoard
    {
        public int width;
        public int height;
        public Func<int, int, int> Operation;
        public IPrint Printer;

        public MultiBoard(Func<int, int, int> Operation, IPrint Printer, int width = 9, int height = 9)
        {
            this.width = width;
            this.height = height;
            this.Operation = Operation;
            this.Printer = Printer;
        }

        public void CalculateAndPrint(string message)
        {
            Printer.Write(message);
            Printer.NewLine();

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Printer.Write($"{(this.Operation(i, j)).ToString().PadLeft(2)} ");
                }
                Printer.NewLine();
            }
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
