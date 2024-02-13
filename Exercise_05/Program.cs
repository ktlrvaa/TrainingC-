namespace Exercise_05
{
    internal class Program
    {
        // УПРАЖНЕНИЕ ПЕРЕГРУЗКА ОПЕРАТОРОВ
        static void Main(string[] args)
        {
            State aragon = new State { Area = 23, Population = 2 };
            State kastilia = new State { Area = 41, Population = 5 };
            State spain = new State();
            spain.AddOfStates(aragon, kastilia, spain);
            Console.WriteLine(spain.Population);
        }
    }
}