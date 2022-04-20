using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    // Объявление класса <Фигура>
    public class Shape
    {
        // Члены класса:
        // Поля.
        protected string FName;
        public Shape()
        {
            FName = "Неопределенная фигура";
        }
        virtual public string Name  //Наименование фигуры
        {
            get { return FName + " (неопределенная фигура)"; }
        }
    }
    public class Rectangle : Shape
    {
        // Члены класса:
        // Конструкторы
        public Rectangle()
        {
            FName = "Прямоугольник";
        }
        override public string Name  // свойство, заменяющее элемент базового класса  
        {
            get { return FName; }
        }
    }

    public class Circle : Shape
    {
        // Члены класса:
        // Конструкторы
        public Circle()
        {
            FName = "Окружность";
        }
        override public string Name  // свойство, заменяющее элемент базового класса  
        {
            get { return FName + ""; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // То же самое, но с использование массива
            Shape[] MyShape = new Shape[3];
            MyShape[0] = new Rectangle();
            MyShape[1] = new Circle();
            MyShape[2] = new Shape();
            foreach (Shape elem in MyShape) Console.WriteLine(elem.Name);
            Console.ReadKey();
        }
    }
}