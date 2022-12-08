namespace MultiplicationBoard
{
    internal class PrintToConsole : IPrint
    {

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void NewLine()
        {
            Console.WriteLine();
        }
    }
}
