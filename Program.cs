using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Створити неузагальнений клас точки у тривимірному просторі з цілими координатами (Point3D), який успадковується від generic-класу Point2D<T>.
//Реалізувати у класі:
//■ конструктор з параметрами, який приймає початкові значення для координат точки
//■ метод ToString()


namespace Point3D_Class
{
    public class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D(T x, T y) { X = x; Y = y; }
        public Point2D() { X = default(T); Y = default(T); }

    }


    public class Point3D : Point2D<int>
    {
        public int Z { get; set; }

        public Point3D() : base() { Z = default; }
        public Point3D(int x, int y, int z) : base(x, y) { Z = z; }

        public override string ToString()
        {
            return $"(X = {X}, Y = {Y}, Z = {Z})";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            { 
                var p3 = new Point3D();
                Console.WriteLine($"Point p3 object with default value: {p3.ToString()}");
                var p4 = new Point3D(100, 200, 50);
                Console.WriteLine($"Point p3 object with given value: {p4.ToString()}");
            }
        }
    }
}
