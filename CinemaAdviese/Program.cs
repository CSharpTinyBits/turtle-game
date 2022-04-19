using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Эта программа поможет Вам подобрать фильм для вечернего просмотра");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);
            Console.WriteLine("Выберите жанр фильма: комедия, драма, фантастика, эротика, триллер, боевик");
            String genre = Console.ReadLine();
            Console.WriteLine("Рекомендую посмотреть следующие фильмы:");
            if (genre == "комедия")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Любовь И голуби");
                Console.WriteLine("Ширли-мырли");
                Console.WriteLine("Девчата");
                Console.WriteLine("Ёлки");
            }
            else if (genre == "драма")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Брат");
                Console.WriteLine("Сталинград");
                Console.WriteLine("Грозовые ворота");
                Console.WriteLine("В бой идут одни старики");
            }
            else if (genre == "эротика")
            {
                Console.WriteLine("Сколько Вам лет?");
                String yearsString = Console.ReadLine();
                int years = Int32.Parse(yearsString);
                if(years < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Этот жанр доступен только по достижению 18-ти лет");
                    Console.WriteLine("Приходите через " + (18 - years) + " лет");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("2 girls 1 cup");
                    Console.WriteLine("Нимфоманка");
                }
            }
            else if(genre == "триллер")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Начало");
                Console.WriteLine("Исчезнувшая");
                Console.WriteLine("Проклятие монахини");
                Console.WriteLine("Хищник");
            }
            else if (genre == "боевик")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Форсаж 8");
                Console.WriteLine("Стражи галактики");
                Console.WriteLine("Мстители");
                Console.WriteLine("Джон Уик 2");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Алиса в стране чудес");
                Console.WriteLine("Звездные войны");
                Console.WriteLine("Матрица");
                Console.WriteLine("Гарри Поттер и философский камень");
            }
            Console.ReadLine();
        }
    }
}
