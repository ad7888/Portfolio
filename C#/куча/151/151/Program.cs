using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace _151
{


    class Program
    {
        /*По ТЗ был дан класс на основе его построить
        *И вызвать его
        */
        public class Rectangle

        {

            public double A;

            public double B;

            public string FName;

            public double GetPerimeter()

            {
                return (A + B) * 2;
            }

            public void SetName(string newName)

            {
                FName = newName;
            }

            public string GetName()

            {
                return FName;
            }
            //Конструктор 2 по точкам
            public void WriteXY(int x1, int x2,int x3, int y1, int y2, int y3)
            {

                A = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                B = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с первым объектом");
            // Создание первого объекта на основе класса Rectangle
            Rectangle myRect1 = new Rectangle();

            // Установим значение полей

            myRect1.A = 5;

            myRect1.B = 10;

            // Вызываем метод изменения названия фигуры

            myRect1.SetName("Большой прямоугольник");

            // определение периметра фигуры

            double Perim1 = myRect1.GetPerimeter();

            // Выводим имя фигуры

            Console.WriteLine(myRect1.FName);

            // значение периметра

            Console.WriteLine(Perim1);

            Console.ReadKey();

            Console.WriteLine("Работа со вторым объектом");

            // Создание второго объекта на основе класса Rectangle

            Rectangle myRect2 = new Rectangle();

            // Вызов Конструктор 2

            myRect2.WriteXY(0,0,1,0,1,1);

            // Вызываем метод изменения названия фигуры

            myRect2.SetName("Маленький прямоугольник");

            // определение периметра фигуры

            double Perim2 = myRect2.GetPerimeter();

            // Выводим имя фигуры

            Console.WriteLine(myRect2.FName);

            // значение периметра

            Console.WriteLine(Perim2);
            
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(myRect2.A);
            Console.WriteLine(myRect2.B);
            Console.ReadKey();
        }
    }
}

