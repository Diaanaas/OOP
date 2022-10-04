using System;
namespace gObject               // HomeTask 4 (абстрактний клас)
{
    class Program
    {
        abstract class GeoObject
        {
            public string coordY { get; set; }
            public string coordX { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public virtual void getInfo()
            {

            }
        }

        class Mount : GeoObject
        {
            public double highestPoint { get; set; }
            public override void getInfo()
            {
                Console.WriteLine($"Назва об'єкту: {name}");
                Console.WriteLine($"Координата X: {coordX}");
                Console.WriteLine($"Координата Y: {coordY}");
                Console.WriteLine($"Опис об'єкту: {description}");
                Console.WriteLine($"Найвища точка: {highestPoint} м");
            }
        }

        class River : GeoObject
        {
            public string speed { get; set; }
            public double length { get; set; }
            public override void getInfo()
            {
                Console.WriteLine($"Назва об'єкту: {name}");
                Console.WriteLine($"Координата X: {coordX}");
                Console.WriteLine($"Координата Y: {coordY}");
                Console.WriteLine($"Опис об'єкту: {description}");
                Console.WriteLine($"Швидкiсть течiї (м/с): {speed}");
                Console.WriteLine($"Загальна довжина: {length} м");
            }
        }

        static void Main(string[] args)
        {
            Mount mount = new Mount();
            mount.name = "Говерла";
            mount.highestPoint = 2.061;
            mount.description = "Говерла (Howerla) — найвища вершина Українських Карпат i найвища точка України.";
            mount.coordX = "48° 09′ 37″";
            mount.coordY = "24° 30′ 00″";

            Console.WriteLine("Бiльше iнформацiї про Говерлу ? y(yes)/n(no)");
            string check = Console.ReadLine();
            if (check == "yes" || check == "y")
            {
                Console.WriteLine("\n");
                mount.getInfo();
            }

            River river = new River();
            river.name = "Днiпро";
            river.description = "Днiпро — четверта за довжиною i третя за площею басейну рiчка Європи, рiчка з найдовшою течiєю в Українi.";
            river.coordX = "55° 52′ 19″";
            river.coordY = "33° 43′ 26″";
            river.length = 2.201;
            river.speed = "0.4–1.2";
            Console.WriteLine("");
            Console.WriteLine("\n");
            Console.WriteLine("Бiльше iнформацiї про р.Днiпро ? y(yes)/n(no)");
            check = Console.ReadLine();
            if (check == "yes" || check == "y")
            {
                Console.WriteLine("\n");
                river.getInfo();
                Console.ReadLine();
            }
        }
    }
}