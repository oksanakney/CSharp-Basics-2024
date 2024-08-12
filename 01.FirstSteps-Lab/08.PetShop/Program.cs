namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine()!);
            int catFoodCount = int.Parse(Console.ReadLine()!);

            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;

            double sum = dogFoodCount * dogFoodPrice + catFoodCount * catFoodPrice;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
