using System;

namespace Examen_Mvvm
{
    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public string Calculate()
        {
            if (A == 0 || B == 0 || C == 0)
            {
                return "Error: Campos vacíos";
            }

            double discriminant = B * B - 4 * A * C;
            if (discriminant < 0)
            {
                return "Error: No hay soluciones reales";
            }

            double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
            double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);

            return $"x = {x1} o x = {x2}";
        }

        public void Clear()
        {
            A = 0;
            B = 0;
            C = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation();

            Console.WriteLine("Ingrese valor de a:");
            equation.A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese valor de b:");
            equation.B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese valor de c:");
            equation.C = Convert.ToDouble(Console.ReadLine());

            string result = equation.Calculate();

            Console.WriteLine("Resultado:");
            Console.WriteLine(result);

            Console.WriteLine("Presione una tecla para limpiar...");
            Console.ReadKey();

            equation.Clear();

            Console.WriteLine("Campos limpios. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}