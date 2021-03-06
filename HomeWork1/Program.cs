﻿//Шадрин Максим
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{   public class Person
    {
        public string Name;
        public string Surname;
        public string Age;
        public string Height;
        public string City;

        /// <summary>
        /// Вывод массива строк в центре экрана
        /// </summary>
        /// <param name="str"></param>
        public void Print()
        {
            Console.Clear();
            string[] str = { Name, Surname, City };
            int top = Console.WindowHeight / 2 - str.Length / 2;
            int strLength;
            for (int i = 0; i < str.Length; i++, top++)
            {
                strLength = str[i].Length;
                if (strLength % 2 != 0)
                    strLength++;
                Console.SetCursorPosition(Console.WindowWidth / 2 - strLength / 2, top);
                Console.Write(str[i]);
            }
        }

        /// <summary>
        /// Пауза
        /// </summary>
        public void Pause()
        {
            Console.ReadLine();
        }
    }
    class Program
    {
        /// <summary>
        /// Определение расстояния между двумя точками
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>Расстояние между точками</returns>
        static double LengthAB(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        /// <summary>
        /// Вывод массива строк в центре экрана
        /// </summary>
        /// <param name="str"></param>
        static void Print(string[] str)
        {
            Console.Clear();
            int top = Console.WindowHeight / 2 - str.Length / 2;
            int strLength;
            for (int i = 0; i < str.Length; i++, top++)
            {
                strLength = str[i].Length;
                if (strLength % 2 != 0)
                    strLength++;
                Console.SetCursorPosition(Console.WindowWidth / 2 - strLength / 2, top);
                Console.Write(str[i]);
            }
        }

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
            /*
            2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах
            Используем ранее введенные вес и рост.
            */
            float m = Convert.ToInt32(Weight);
            float h = Convert.ToInt32(Height);
            h = h / 100;
            float l = m / (h * h);
            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {l}");
            Console.ReadLine();
            #endregion

            #region Задание 3
            /*
            3.
            а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            */
            Console.Clear();
            Console.WriteLine("Определение расстояния между двумя точками");
            Console.Write("Введите x1: ");
            string x1_string = Console.ReadLine();
            double x1 = Convert.ToDouble(x1_string);
            Console.Write("Введите y1: ");
            string y1_string = Console.ReadLine();
            double y1 = Convert.ToDouble(y1_string);
            Console.Write("Введите x2: ");
            string x2_string = Console.ReadLine();
            double x2 = Convert.ToDouble(x2_string);
            Console.Write("Введите y2: ");
            string y2_string = Console.ReadLine();
            double y2 = Convert.ToDouble(y2_string);
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //а)
            Console.Write("Расстояние между точками: ");            
            Console.WriteLine("{0:F2}", r);
            //б)
            Console.Write("Расстояние между точками: ");
            Console.WriteLine("{0:F2}", LengthAB(x1, y1, x2, y2));
            Console.ReadLine();
            #endregion

            #region Задание 4
            /*
            4. Написать программу обмена значениями двух переменных.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
            */
            Console.Clear();
            Console.WriteLine("Обмен значениями. Если значения числовые, то обмен значений будет без использования третьей переменной");
            Console.Write("Введите x1: ");
            string x1_str = Console.ReadLine();
            Console.Write("Введите x2: ");
            string x2_str = Console.ReadLine();
            Console.WriteLine($"Вы ввели x1 \"{x1_str}\" и х2 \"{x2_str}\"");
                   
            bool isx1Num = double.TryParse(x1_str, out double a);
            bool isx2Num = double.TryParse(x2_str, out double b);

            Console.WriteLine("Меняем значения");
            string y = x1_str;
            x1_str = x2_str;
            x2_str = y;
            Console.WriteLine($"Теперь x1 \"{x1_str}\" и х2 \"{x2_str}\"");

            if (isx1Num && isx2Num)
                {
                a = a + b;
                b = b - a;
                b = -b;
                a = a - b;
                Console.WriteLine($"Теперь x1 \"{a}\" и х2 \"{b}\"");
                }
            else
                Console.WriteLine("Не являются числами! Без использования третьей переменной поменять нельзя!");
            Console.ReadLine();
            #endregion

            #region Задание 5
            /*
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организуйте в центре экрана
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
            */
            Console.Clear();
            Console.WriteLine("Вывод данных на экран в центре");
            Console.WriteLine("Введите данные:");
            Console.Write("Имя: ");
            Name = Console.ReadLine();
            Console.Write("Фамилия: ");
            Surname = Console.ReadLine();
            Console.Write("Город проживания: ");
            string City = Console.ReadLine();

            //а)
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Город проживания: {City}");
            Console.ReadLine();

            //б)
            string[] str = { Name, Surname, City };
            Console.Clear();
            int top = Console.WindowHeight / 2 - str.Length / 2;
            int strLength;
            for (int i = 0; i < str.Length; i++, top++)
            {
                strLength = str[i].Length;
                if (strLength % 2 != 0)
                    strLength++;   
                Console.SetCursorPosition(Console.WindowWidth / 2 - strLength / 2, top);
                Console.Write(str[i]);
            }
            Console.ReadLine();

            //в)
            Console.Clear();
            Print(str);
            Console.ReadLine();
            #endregion

            #region Задание 6
            /*
            6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            */
            Console.Clear();
            Console.WriteLine("Использование класса");
            Person ClassPerson = new Person
            {
                Name = Name,
                Surname = Surname,
                Age = Age,
                Height = Height,
                City = City
            };
            ClassPerson.Pause();            
            ClassPerson.Print();
            ClassPerson.Pause();
            #endregion
        }
    }
}
