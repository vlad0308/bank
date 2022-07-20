using System;

namespace GitProgram
{
    class Program
    {
        static void Information()
        {
            Console.WriteLine("Vlad Makushenko");
            Console.WriteLine("Дата рождения 03,08,1999");
        }
        static void Card(int cart1, int cart2)
        {

            Console.WriteLine("cart visa : **** **** **** 1234");
            Console.WriteLine("cart mastercart : **** **** **** 4321");
            Console.Write("Посмотреть баланс (visa - 1, mastercart - 2):");
            int cartBalans = Convert.ToInt32(Console.ReadLine());
            if (cartBalans == 1) { Console.WriteLine($"visa = {cart1}"); }
            else if (cartBalans == 2) { Console.WriteLine($"mastercart = {cart2}"); }
            else { Console.WriteLine("Ошибка.карта не найдено"); }
        }
        static int Transactions(int cart1, int cart2)
        {
            Console.Write("Введите карту (visa - 1, mastercart - 2) : ");
            int cartBalans = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите катру получателя");
            string catrBalansMen = Console.ReadLine();

            Console.WriteLine("Введите суму для перевода");
            int money = Convert.ToInt32(Console.ReadLine());

            if (cartBalans == 1)
            {
                if (cart1 > money)
                {
                    cart1 -= money;
                    Console.WriteLine($"Перевод успешный. Баланс: {cart1}");
                    return cart1;
                }
                else { Console.WriteLine("Ошибка, недостаточно средств"); return cart1; }

            }
            else if (cartBalans == 2)
            {
                if (cart2 > money)
                {
                    cart2 -= money;
                    Console.WriteLine($"Перевод успешный. Баланс: {cart2}");
                    return cart2;
                }
                else { Console.WriteLine("Ошибка, недостаточно средств"); return cart2; }

            }
            else { Console.WriteLine("Ошибка.карта не найдено"); return cart1; return cart2; }


        }
        static void Main(string[] args)
        {
            int cart1 = 10000, cart2 = 5000;
            int exite = 1;
            while (exite == 1)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1.Информация\n2.Карти\n3.Первевод\n4.Выход");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        {
                            Information(); exite = 1; break;
                        }
                    case "2":
                        {
                            Card(cart1, cart2); exite = 1; break;
                        }
                    case "3":
                        {
                            Transactions(cart1, cart2); exite = 1; break;
                        }
                    case "4":
                        {
                            exite = 0; break;
                        }
                    default: { break; }

                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
