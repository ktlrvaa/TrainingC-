namespace Exercise_02
{
    internal class Program
    {
        //УПРАЖНЕНИЕ С ЦИКЛАМИ

        /* За каждый месяц банк начисляет к сумме вклада 7% от суммы.
         * Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
         * А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
        Для вычисления суммы с учетом процентов используйте цикл for.
        Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine())
        (сумма вклада будет представлять тип decimal).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= period; i++)
            {
                sum += sum * 0.07M;
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            Console.ReadKey();
        }
    }
}