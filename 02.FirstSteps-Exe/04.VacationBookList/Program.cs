namespace _04.VacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int pages = int.Parse(Console.ReadLine()!);
            int pagesPerHour = int.Parse(Console.ReadLine()!);
            int days = int.Parse(Console.ReadLine()!);

            int pagesPerDay = pages / pagesPerHour / days;
            Console.WriteLine(pagesPerDay);
        }
    }
}
