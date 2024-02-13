namespace Exercise_08
{
    internal class Program
    {
        //УПРАЖНЕНИЕ

        /*        Вывести на экран ряд натуральных чисел от минимума до максимума с шагом.
                    Например, если минимум 10, максимум 35, шаг 5,
                    то вывод должен быть таким: 10 15 20 25 30 35.
                    Минимум, максимум и шаг указываются пользователем (считываются с клавиатуры).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное значение: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            int step = Convert.ToInt32(Console.ReadLine());
            if (minValue > maxValue)
            {
                Console.WriteLine("Ошибка. Минимальное значение больше, чем максимальное.");
            }
            else
            {
                for (int i = minValue; i < maxValue; i += step)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}