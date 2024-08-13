namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = int.Parse(Console.ReadLine()!);
            double width = int.Parse(Console.ReadLine()!);
            double height = int.Parse(Console.ReadLine()!);
            double percentage = double.Parse(Console.ReadLine()!);

            double volumeInLiters = (length * width * height) / 1000;
            double volumeWaterNeeded = volumeInLiters * (1 - percentage / 100);

            Console.WriteLine(volumeWaterNeeded);
        }
    }
}
