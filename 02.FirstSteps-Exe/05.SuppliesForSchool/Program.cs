namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine()!);
            int markers = int.Parse(Console.ReadLine()!);
            int detergent = int.Parse(Console.ReadLine()!);
            double discount = double.Parse(Console.ReadLine()!);
           
            double penPrice = 5.8;
            double markerPrice = 7.2;
            double detergentPrice = 1.2;
            double discountRate = 1 - (discount / 100);
            double sum = (penPrice * pens + markerPrice * markers + detergentPrice * detergent) * discountRate;

            Console.WriteLine(sum);
        }
    }
}
