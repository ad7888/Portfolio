using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    // Объявление класса
    public class Rectangle
    {
        // Члены класса:
        // Поля.
        private string FName;
        private int[] FAB = new int[2];  // декларируем массив с двумя элементами

        // Индексатор с целочисленным параметром (индексом)
        public int this[int index]
        {
            get
            {
                return FAB[index];
            }
            set
            {
                FAB[index] = value;
            }
        }
        // Конструктор с аргументами
        public Rectangle(string Name, int SideA, int SideB)
        {
            FAB[0] = SideA;
            FAB[1] = SideB;
            FName = Name;
        }
        // Свойства
        // Только для чтения
        public int Perimeter
        {
            get { return (FAB[0] + FAB[1]) * 2; }
        }
        // Для чтения и для записи
        public string Name
        {
            set { FName = value; }
            get { return FName; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта на основе класса Rectangle (Большой прямоугольник со сторонами 5 и 10)
            Rectangle myRect = new Rectangle("Большой прямоугольник", 5, 10);
            // Выводим свойства фигуры
            // имя 
            Console.WriteLine(myRect.Name);
            // значение сторон (до изменения)
            Console.WriteLine(myRect[0]);
            Console.WriteLine(myRect[1]);
            Console.ReadKey();

            // Переустановим значение длин сторон прямоугольника
            myRect[0] = 10;
            myRect[1] = 20;

            // Выводим свойства фигуры
            // значение сторон (после изменения)
            Console.WriteLine(myRect[0]);
            Console.WriteLine(myRect[1]);
            Console.ReadKey();
            // значение периметра
            Console.WriteLine(myRect.Perimeter);
            Console.ReadKey();

        }
    }
}
