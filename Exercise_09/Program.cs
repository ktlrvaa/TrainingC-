namespace Exercise_09
{
    internal class Program
    {
        //УПРАЖНЕНИЕ
        /*Вывести на экран таблицу умножения(от 1 до 9).*/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}x{1}={2} ", new object[] { i, j, i * j });
                }
                Console.Write('\n');
            }
            Console.Read();
        }
    }
}