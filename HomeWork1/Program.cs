using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            /*
            1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
            а) используя склеивание;
            б) используя форматированный вывод;
            в) *используя вывод со знаком $.
            */

            Console.WriteLine("Анкета");
            Console.WriteLine("Введите данные:");
            Console.Write("Имя: ");
            string Name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string Surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string Age = Console.ReadLine();
            Console.Write("Рост (см): ");
            string Height = Console.ReadLine();
            Console.Write("Вес (кг): ");
            string Weight = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Данные анкеты:");
            Console.WriteLine("Имя: " + Name + ", Фамилия: " + Surname + ", Возраст: " + Age + ", Рост: " + Height + ", Вес: " + Weight);
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", Name, Surname, Age, Height, Weight);
            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Рост: {Height}, Вес: {Weight}");
            Console.ReadLine();
            #endregion

            #region Задание 2
            float m = Convert.ToInt32(Weight);
            float h = Convert.ToInt32(Height);
            h = h / 100;
            float l = m / (h * h);
            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {l}");
            Console.ReadLine();
            #endregion
        }
    }
}
