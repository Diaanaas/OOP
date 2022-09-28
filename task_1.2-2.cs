using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr11_1
{
    using Microsoft.VisualBasic;
    using System.Windows.Forms;
    class Program
    {
        public static bool TopMost { get; private set; }

        static void Main()
        {
            // Текстовая переменная: 
            double N;
            // Отображение окна с полем ввода: 
            N = Convert.ToDouble(Interaction.InputBox(
                "Введите целое число: ",    // Текст над полем ввода 
                "Ввод данных..."            // Название окна
                ));
            // Еще одна текстовая переменная: 
            string text = "Вы ввели число " + Convert.ToInt32(N) + " !";
            // Окно с сообщением:
            // BringToFront();
            MessageBox.Show(text, "Output");
        }
    }
}