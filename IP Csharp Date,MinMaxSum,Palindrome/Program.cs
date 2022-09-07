namespace IP_Csharp_Date_MinMaxSum_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Data
            DateTime localDate = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            // Liczby całkowite 
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("\nType in number: ");
                var number = int.Parse(Console.ReadLine());
                numbers.Add(number);
                Console.Write("Continue adding?(y/n): ");
                var key = Console.ReadKey().KeyChar;

                if (key == 'n')
                {
                    Console.WriteLine("\n");
                    break;
                }
            }
            Console.WriteLine("Your max value is: " + numbers.Max());
            Console.WriteLine("Your minimum value is: " + numbers.Min());
            Console.WriteLine("Sum of your values is: " + numbers.Sum());


            // Palindrome

            Console.Write("Type the word to check if it's palindrome: ");
            string word = Console.ReadLine();


            var result = getStatus(word);

            if (result == true)
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else if (result == false)
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
            Console.ReadLine();

        }

        public static bool getStatus(string myString)
        {

            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            return myString.Equals(temp);

        }
    }
}