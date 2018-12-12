using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop;

namespace oop
{
    abstract class Polygon : IComparable<Polygon>
    {
        public double Ax, Ay, Bx, By, Cx, Cy;
        public Polygon(double Ax, double Ay, double Bx, double By, double Cx, double Cy)
        {
            this.Ax = Ax;
            this.Ay = Ay;
            this.Bx = Bx;
            this.By = By;
            this.Cx = Cx;
            this.Cy = Cy;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public int CompareTo(Polygon obj)
        {
            if (Ax > obj.Ax)
                return 1;
            if (Ax < obj.Ax)
                return -1;
            else
                return 0;
        }
    }
    class Triangle : Polygon
    {
        public Triangle(double Ax, double Ay, double Bx, double By, double Cx, double Cy) : base(Ax, Ay, Bx, By, Cx, Cy)
        {
            Console.WriteLine("Создан треугольник с вершинами А[" + Ax + "," + Ay + "], B[" + Bx + "," + By + "], C[" + Cx + "," + Cy + "]");
        }
        public override double Area()
        {
            Console.WriteLine("Класс треугольник: расчет площади");
            return 0;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Класс треугольник: расчет периметра");
            return 0;
        }
        public string TypeOfTriangle()
        {
            Console.WriteLine("Определение типа треугольника");
            return "type";
        }
    }
    class Parallelogram : Polygon
    {
        double Dx, Dy;
        public Parallelogram (double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy) : base(Ax, Ay, Bx, By, Cx, Cy)
        {
            this.Dx = Dx;
            this.Dy = Dy;
            Console.WriteLine("Создан параллелограмм с вершинами А[" + Ax + "," + Ay + "], B[" + Bx + "," + By + "], C[" + Cx + "," + Cy + "], D[" + Dx + "," + Dy + "]");
        }
        public override double Area()
        {
            Console.WriteLine("Класс параллелограмм: расчет площади");
            return 0;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Класс параллелограмм: расчет периметра");
            return 0;
        }
        public double Heigth()
        {
            Console.WriteLine("Класс параллелограмм: расчет высоты");
            return 0;
        }
    }
    class Rhomb : Parallelogram
    {
        public Rhomb (double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy) : base(Ax, Ay, Bx, By, Cx, Cy, Dx, Dy)
        {
            Console.WriteLine("Этот параллелограмм является ромбом");
        }
        public double InRadius()
        {
            Console.WriteLine("Расчет радиуса вписанной окружности");
            return 0;
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Triangle triangle1 = new Triangle(1, 1, 3, 2, 2, 4);        
        Parallelogram par1 = new Parallelogram(-1, 1, -3, 2, -2, 4, -4, 5);
        Rhomb rhomb = new Rhomb(2, 2, 4, 3, 3, 4, 5, 5);        
        List<Polygon> col = new List<Polygon>();
        col.Add(triangle1);
        col.Add(par1);
        col.Add(rhomb);
        col.Sort();        
        Console.WriteLine("Объекты отсортированы по возрастанию поля Ax");
        foreach (Polygon o in col)
        {
            Console.WriteLine(o + " " + o.Ax);            
        }
        Console.ReadKey();
        }
    }

