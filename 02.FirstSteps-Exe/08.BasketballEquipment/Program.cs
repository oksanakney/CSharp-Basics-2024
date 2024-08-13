namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualTax = double.Parse(Console.ReadLine()!);

            double boots = annualTax * 0.6;
            double dress = boots * 0.8;
            double ball = dress / 4;
            double accessories = ball / 5;

            double sum = annualTax + boots + dress + ball + accessories;

            Console.WriteLine(sum);
        }
    }
}
