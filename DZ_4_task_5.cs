using System;
using System.Collections.Generic;

namespace prod                             // Завдання 5 (без Windows Forms)
{
    static class Program
    {
        class Goods                         // Додаємо клас "Товар"
        {
            public double price { get; set; }
            public string origin { get; set; }
            public string name { get; set; }
            public string packingDate { get; set; }
            public string about { get; set; }

            public virtual void Display()
            {
                Console.WriteLine($"Назва: {name}");
                Console.WriteLine($"Цiна: {price}");
                Console.WriteLine($"Опис товару: {about}");
                Console.WriteLine($"Країна походження: {origin}");
                Console.WriteLine($"Дата пакування: {packingDate}");                
                
            }

            public virtual void Add()
            {
                Console.WriteLine("Введіть назву: ");
                name = Console.ReadLine();   
                Console.WriteLine("Введіть ціну: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Опис товару: ");
                about = Console.ReadLine();     /* ... інші поля аналогічно */

            }
        }

        class Products : Goods              // Додаємо клас-нащадок "Продукти"
        {
            public string expDate { get; set; }
            public int quantity { get; set; }
            public string unitOfMeasure { get; set; }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Термiн придатностi: {expDate}");
                Console.WriteLine($"Кiлькiсть: {quantity}");
                Console.WriteLine($"Одиниця вимiру: {unitOfMeasure}");
            }

            public override void Add()
            {
                base.Add();
            }
        }

        class Books : Goods             // Додаємо клас-нащадок "Книги"
        {
            public string edition { get; set; }
            public int pagesQuantity { get; set; }
            public string authorsList { get; set; }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Видавництво: {edition}");
                Console.WriteLine($"Кiлькiсть сторiнок: {pagesQuantity}");
                Console.WriteLine($"Перелiк aвторiв: {authorsList}");
            }

            public override void Add()
            {
                base.Add();
            }
        }

        static void Main()
        {
            List<Goods> goods = new List<Goods>();
            Products prod1 = new Products();
            prod1.name = "Product1";
            prod1.price = 1300.50;
            prod1.about = "Description of Product1";
            prod1.origin = "Country1";
            prod1.packingDate = "07.09.2022";
            prod1.expDate = "07.12.2022";
            prod1.quantity = 1;
            prod1.unitOfMeasure = "kg";
            goods.Add(prod1);

            Books book1 = new Books();
            book1.name = "Book1";
            book1.price = 877.50;
            book1.about = "Book1 summary ... ";
            book1.origin = "Ukraine, Kyiv";
            book1.packingDate = "04.10.2017";
            book1.edition = "Editio1";
            book1.pagesQuantity = 277;
            book1.authorsList = "Author1, Author2, ...";
            goods.Add(book1);

            Console.WriteLine("Бажаєте переглянути товари ? (yes/no)");
            string check = Console.ReadLine();
            if (check != "yes" && check != "y")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------");
            

            foreach (Goods good in goods)
            {
                good.Display();
                Console.WriteLine("----------------");
            }

            Console.WriteLine("Бажаєте додати продукт ? (yes/no)");
            check = Console.ReadLine();
            if (check == "yes" || check == "y")
            {
                Products product1 = new Products();
                product1.Add();
                goods.Add(product1);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("Бажаєте додати книгу ? (yes/no)");
            check = Console.ReadLine();
            if (check == "yes" || check == "y")
            {
                Books book2 = new Books();
                book2.Add();
                goods.Add(book2);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("Бажаєте видалити Товар ? (yes/no)");
            check = Console.ReadLine();
            if (check == "yes" || check == "y")
            {
                Console.WriteLine("Бажаєте видалити Product1 ? yes/no");
                check = Console.ReadLine();
                if (check == "yes" || check == "y")
                {
                    goods.Remove(prod1);
                    Console.WriteLine("----------------");
                }
                Console.WriteLine("Бажаєте видалити Book1 ? yes/no");
                check = Console.ReadLine();
                if (check == "yes" || check == "y")
                {
                    goods.Remove(book1);
                    Console.WriteLine("----------------");
                }

            }
            Console.WriteLine("----------------");
            if (goods.Count != 0)
            {
                foreach (Goods good in goods)
                {
                    good.Display();
                    Console.WriteLine("----------------");
                }
            }
            else
            {
                Console.WriteLine("Нема жодних Товарів");
                Console.WriteLine("----------------");
            }



        }
    }
}