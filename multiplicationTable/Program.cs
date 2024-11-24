namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //welcome to user 

            Console.WriteLine("welcome to Multiplication Table app ");
            // ask user to enter value
            //Console.WriteLine("please enter number");
            //// read value
            //byte number = 0;
            //bool isConverted = byte.TryParse(Console.ReadLine(), out number);
            //if (!isConverted) { Console.WriteLine("please inter valid number "); return; }
            //else

            //{

            for (int k = 1; k < 11; k++)
            {
                Console.WriteLine($"Multiplication Table {k} ");

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{k}*{i} = {k * i}");
                }
            }

        }
    }
}
