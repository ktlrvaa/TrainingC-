using System.Security.Cryptography;

namespace Exercise_06
{
    internal class Program

    // УПРАЖНЕНИЕ 

    /*Создать программу, генерирующую для пользователя случайный пароль заданной длины и набора символов.
     * Условия: 
     * будет генерировать пароль заданной длины от 5 до 30 символов
     * сможет использовать для генерации пароля цифры (от 0 до 9),
     * строчные и прописные латинские символы (a-z, A-Z), 
     * а также спецсимволы (#, $, %, ! и другие)*/
    {
        static void Main(string[] args)
        {
            string pass = GetPass(16);
            Console.WriteLine(pass);
        }

        public static string GetPass(int x)
        {
            string pass = "";
            var r = new Random();
            while (pass.Length < x)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    pass += c;
            }
            return pass;
        }
    }
}