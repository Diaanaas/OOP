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
            // ��������� ����������: 
            double N;
            // ����������� ���� � ����� �����: 
            N = Convert.ToDouble(Interaction.InputBox(
                "������� ����� �����: ",    // ����� ��� ����� ����� 
                "���� ������..."            // �������� ����
                ));
            // ��� ���� ��������� ����������: 
            string text = "�� ����� ����� " + Convert.ToInt32(N) + " !";
            // ���� � ����������:
            // BringToFront();
            MessageBox.Show(text, "Output");
        }
    }
}