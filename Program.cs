namespace MultiplicationBoard
{
    internal class Program
    {
        public static int myMultiply(int a, int b)
        {
            return a * b;
        }
        private static void Main(string[] args)
        {
            PrintToConsole Printer = new PrintToConsole();
            MultiBoard board = new(MultiBoard.Multiply, Printer);

            string message =
                $"Hello, this is board for operation: {nameof(MultiBoard.Multiply)}\n" +
                $"Printing board with: {nameof(PrintToConsole)}";

            board.CalculateAndPrint(message);
        }
    }

    interface IPrint
    {
        void Write(string s);
        void NewLine();
    }
}