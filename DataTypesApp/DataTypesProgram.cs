namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int apple_Count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + apple_Count + " apples(s): ");
            double apple_Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + apple_Count + " apples(s) is " + apple_Price);
            Console.WriteLine("The value of original price is " + apple_Price);
            int c_apple_Price = (int)apple_Price;
            Console.WriteLine("The value of converted price is " + c_apple_Price);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}