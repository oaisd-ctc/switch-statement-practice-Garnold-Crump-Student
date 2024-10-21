namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    Console.WriteLine("your number is zero");
                    break;

                case 1:
                    Console.WriteLine("your number is one");
                    break;


                case 2:
                    Console.WriteLine("your number is two");
                    break;

                case 3:
                    Console.WriteLine("your number is three");
                    break;

                case 4:
                    Console.WriteLine("your number is four");
                    break;

                case 5:
                    Console.WriteLine("your number is five");
                    break;

                case 6:
                    Console.WriteLine("your number is six");
                    break;

                case 7:
                    Console.WriteLine("your number is seven");
                    break;


                case 8:
                    Console.WriteLine("your number is eight");
                    break;

                case 9:
                    Console.WriteLine("your number is nine");
                    break;


                case 10:
                    Console.WriteLine("your number is ten");
                    break;

                default:
                    Console.WriteLine("your number is not in range");
                    Console.ReadLine();
                    break;
            }

        }
    }
}