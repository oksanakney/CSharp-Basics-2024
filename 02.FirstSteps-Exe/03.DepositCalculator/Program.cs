namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            double deposit = double.Parse(Console.ReadLine()!);
            int term = int.Parse(Console.ReadLine()!);
            double annualInterestRate = double.Parse(Console.ReadLine()!);
            
            double result = deposit + term * ((deposit * annualInterestRate / 100) / 12);

            Console.WriteLine(result);
        }
    }
}
