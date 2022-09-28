using System;

namespace task3
{
    class Converter
    {
        private decimal _dollarToUAH;
        private decimal _euroToUAH;
        public Converter(decimal dollarToUAH, decimal euroToUAH)
        {
            _dollarToUAH = dollarToUAH;
            _euroToUAH = euroToUAH;
        }

        public void dollarsToUAH(decimal dollars)
        {
            Console.WriteLine(dollars * _dollarToUAH);
        }

        public void eurosToUAH(decimal euros)
        {
            Console.WriteLine(euros * _euroToUAH);
        }

        public void uahToDollars(decimal UAH)
        {
            Console.WriteLine(UAH / _dollarToUAH);
        }

        public void uahToEuros(decimal UAH)
        {
            Console.WriteLine(UAH / _euroToUAH);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.56M, 35.23M);
            Console.WriteLine("USD to UAH (курс 36,56):");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            converter.dollarsToUAH(money);
            Console.WriteLine(" ");

            Console.WriteLine("UAH to USD (курс 36,56):");
            money = Convert.ToDecimal(Console.ReadLine());
            converter.uahToDollars(money);
            Console.WriteLine(" ");

            Console.WriteLine("EURO to UAH (курс 35,23):");
            money = Convert.ToDecimal(Console.ReadLine());
            converter.eurosToUAH(money);
            Console.WriteLine(" ");

            Console.WriteLine("UAH to EURO (курс 35,23):");
            money = Convert.ToDecimal(Console.ReadLine());
            converter.uahToEuros(money);
            Console.WriteLine(" ");
        }
    }
}