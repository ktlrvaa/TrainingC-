namespace AppProductAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInteraction();
            Console.ReadKey();
        }

        public static void UserInteraction()
        {
            ProductsAccounting productsAccounting = new ProductsAccounting();
            bool looping = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие: \n" +
                    "1. Добавить информацию о новом товаре \n" +
                    "2. Изменить количество существующего товара\n" +
                    "3. Показать товары и количество на складе");
                string key = Console.ReadLine();
                while (key != "1"
                    && key != "2"
                    && key != "3"
                    )
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                    key = Console.ReadLine();
                }
                switch (key)
                {
                    case "1":
                        Console.WriteLine("Чтобы добавить товар в базу, потребуется ввести некоторые данные.");
                        Console.WriteLine("Введите наименование товара: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите артикул этого товара: \n" +
                            "Длина артикула должна быть от 0 до 9 цифр.");
                        int articleAdd = Convert.ToInt32(Console.ReadLine());
                        var resultOfAction = productsAccounting.AddProduct(name, articleAdd);
                        if (resultOfAction)
                        {
                            Console.WriteLine("Товар добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Данные введены неверно, попробуйте еще раз.");
                        }
                        looping = false;
                        ClearOutputScreen();
                        break;
                    case "2":
                        Console.WriteLine("Чтобы изменить количества товара на складе, нужно ввести артикул и новое количество товара.");
                        Console.WriteLine("Введите артикул товара, количество которого нужно изменить: ");
                        int articleСhangingQuantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите актуальное количество: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        var changingQuantity = productsAccounting.ChangingQuantityOfProduct(articleСhangingQuantity, count);
                        if (changingQuantity)
                        {
                            Console.WriteLine("Количество товара изменено.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка.");
                        }
                        looping = false;
                        ClearOutputScreen();
                        break;
                    case "3":
                        Console.WriteLine("Добавленные товары: ");
                        productsAccounting.ReadList();
                        looping = false;
                        ClearOutputScreen();
                        break;
                }
            }
        }
        public static void ClearOutputScreen()
        {
            Console.WriteLine("Чтобы очистить окно вывода нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}