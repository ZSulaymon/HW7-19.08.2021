using System;

namespace HW7._1
{
    class Rectangle
    {
        public double side1, side2;

        //V1
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;                         //инициализация значение 
            this.side2 = side2;
        }
        //V2
        //public Rectangle()
        //{                                                   //инициализация значение          
        //}
        public double AreaCalculator()                  //Метод вычисляющие площадь прямоугольника
        {
            return side1 * side2;
            //return;
        }
        public double PerimeterCalculator()              //Метод вычисляющие Переметр прямоугольника
        {
            return 2 * (side1+side2);
        }
        public double Area
        {                                                    // получить площад
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {                                               // получить перимтр
            get { return PerimeterCalculator(); }
        }
    }


    //new class--V3
    //    class Rectangleе
    //    { 
    //        public double area, Perimeter;
    //          public Rectangleе()
    //            {
    //            }
    //}

    class Program
    {
        static void Main(string[] args)
        {
                            //V1
            Console.WriteLine("Введите площад прямоугольника:");
            double.TryParse(Console.ReadLine(), out double side1);
            Console.WriteLine("Введите перимтр прямоугольника:");
            double.TryParse(Console.ReadLine(), out double side2);
            var rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Площад: {0}, Прямоуголник: {1}", rectangle.Area, rectangle.Perimeter);


                            //V2
            //var rectangle = new Rectangle();
            //Console.WriteLine("Введите площад прямоугольника:");
            //rectangle.side1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите перимтр прямоугольника:");
            //rectangle.side2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Площад: {0}, Прямоуголник: {1}", rectangle.Area, rectangle.Perimeter);

                            //V3
            //var rectanglee  = new Rectangleе();
            //Console.WriteLine("Введите площад прямоугольника:");
            //rectanglee.area = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите перимтр прямоугольника:");
            //rectanglee.Perimeter = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Площад: {0}, Прямоуголник: {1}", rectanglee.area * rectanglee.Perimeter, (rectanglee.area * rectanglee.Perimeter)*2);
        }
    }
}
