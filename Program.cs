using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reg1();
            Reg2();
            Reg3();
            Reg4();
            Reg5();
        }
        static void Reg1()
        {
            Regex r = new Regex(@"^[0-9]{6}$");
            Console.WriteLine("Введите почтовый индекс для проверки ");
            string a = Console.ReadLine();
            if(r.IsMatch(a) == true)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некoрректно");
            }
        }
        static void Reg2()
        {
            Regex r = new Regex(@"^[0-9]{4}\s[0-9]{6}$");
            Console.WriteLine("Введите серию и номер паспорта для проверки ");
            string a = Console.ReadLine();
            if (r.IsMatch(a) == true)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некoрректно");
            }
        }
        static void Reg3()
        {
            Regex r = new Regex(@"^\+79|89[0-9]{9}$");
            Console.WriteLine("Введите номер телефона для проверки ");
            string a = Console.ReadLine();
            if (r.IsMatch(a) == true)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некoрректно");
            }
        }
        static void Reg4()
        {
            Regex r = new Regex(@"^([1-3][0-9][ЛЮ])|([1-4][0-9][ПВБ])$");
            Console.WriteLine("Введите номер группы для проверки ");
            string a = Console.ReadLine();
            if (r.IsMatch(a) == true)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некoрректно");
            }
        }
        static void Reg5()
        {
            Regex r = new Regex(@"^(?=.*[A -Z])(?=.*[a -z]{3,})(?=.*[0 -9]{2,})(?=.*[!@#$%^&*()+=])[A-ZA-z0-9!@#$%^&*()+=]{8,}$");
            Console.WriteLine("Введите пароль для проверки ");
            string a = Console.ReadLine();
            Regex big = new Regex(@"(?=.*[A -Z])");
            Regex small = new Regex(@"(?=.*[a -z]{3,})");
            Regex num = new Regex(@"(?=.*[0 -9]{2,})");
            Regex symb = new Regex(@"(?=.*[!@#$%^&*()+=])");
            Regex amount = new Regex(@"[A-ZA-z0-9!@#$%^&*()+=]{8,}");
            if (r.IsMatch(a) == true)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некoрректно");
                if(big.IsMatch(a) == false)
                {
                    Console.WriteLine("Недостаточно заглавных букв");
                }
                if (small.IsMatch(a) == false)
                {
                    Console.WriteLine("Недостаточно маленьких букв");
                }
                if (num.IsMatch(a) == false)
                {
                    Console.WriteLine("Недостаточно цифр");
                }
                if (symb.IsMatch(a) == false)
                {
                    Console.WriteLine("Недостаточно спец. символов");
                }
                if (amount.IsMatch(a) == false)
                {
                    Console.WriteLine("Недостаточно символов");
                }
            }
        }
    }
}