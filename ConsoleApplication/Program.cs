namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("please input full name(Eng):");
            name = Console.ReadLine();

            Console.WriteLine("Hello,Welcome" + name);

            Console.Write("Please input you height(cm):");
            height = Convert.ToInt16(Console.ReadLine());
            double weight = height - 100;

            Console.WriteLine("Your ideal weight is" + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("Press any key to end program");
            Console.WriteLine();
            

        }
    }
}
