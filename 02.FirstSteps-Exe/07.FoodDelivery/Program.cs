namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine()!);
            int fish = int.Parse(Console.ReadLine()!);
            int vegetarian = int.Parse(Console.ReadLine()!);

            double chickenPrice = 10.35;
            double fishPrice = 12.4;
            double vegetarianPrice = 8.15;

            double foodPrice = chicken * chickenPrice + fish * fishPrice + vegetarian * vegetarianPrice;
            double dessertPrice = foodPrice * 0.2;
            double totalPrice = foodPrice + dessertPrice + 2.5;

            Console.WriteLine(totalPrice);
        }
    }
}
