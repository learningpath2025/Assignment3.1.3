namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputAndCountSpaces();
        }

        static void InputAndCountSpaces()
        {
            Console.Write("Please input a string: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            int spaceCount = CountSpaces(input);
            Console.WriteLine($"\"{input}\" contains {spaceCount} spaces");
        }

        static int CountSpaces(string input)
        {
            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }
    }


}
