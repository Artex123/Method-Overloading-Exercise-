namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add(5, 6);
            Add(7.2, 8.9);
            //Add(1, 0, true);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static void Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;
            if (isCheck == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else if (isCheck == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
            }
            else 
            {
                Console.WriteLine(sum);
            }


        }

    }
}
