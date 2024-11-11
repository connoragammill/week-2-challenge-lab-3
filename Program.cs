namespace week_2_challenge_lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); 
            int number = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Enter the desired width:"); 
            int width = int.Parse(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
