namespace Exercise_07
{
    internal class Program
    {

        //УПРАЖНЕНИЕ 
        /*        Пусть a, b, c – переменные, которым присваиваются введенные числа,
                    а переменная m в конечном итоге должна будет содержать значение
                    наибольшей переменной.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения переменных a, b, c через пробел:");
            string[] numsStr = Console.ReadLine().Split(' ');
            List<int> nums = numsStr.Select(a => int.Parse(a)).ToList();
            Console.WriteLine(GetHighestValue(nums));

        }

        public static int GetHighestValue(List<int> nums)
        {
            int highestValue = int.MinValue;
            foreach (var item in nums)
            {
                if (item > highestValue)
                {
                    highestValue = item;
                }
            }
            return highestValue;
        }
    }
}