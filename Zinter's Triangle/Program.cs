using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zinter_s_Triangle
{
    class Program
    {

        static void Main(string[] args)
        {

            Triangle triangle = new Triangle();


                triangle.setA();
                triangle.setB();

                int sum = triangle.getA() + triangle.getB();

                triangle.setC(sum);

                triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());
                

     



            // Test for side A


            Console.ReadKey();
        }


    }

   public class Triangle
    {
        private int a, b, c;

        public Triangle()  //constructor
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public void setAtest(int a)
        {
            this.a = a;
        }

        public void setBtest(int b)
        {
            this.b = b;
        }

        public void setCtest(int c)
        {
            this.c = c;
        }

        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }
        public int getC()
        {
            return this.c;
        }

        public void setA()
        {
            int itIsANumberEndResult = 0;
            int itIsMoreThanZeroResult = 0;
            int itISLessThanBillionResult = 0;
            string name = "A";
            string number = "1";
            string condition = "";
            do
            {
                Console.WriteLine("Вас приведствует программа Треугольник Зинтера.\nДалее вам следует ввести длины трех сторон нашего треугольника.\n");
                itIsANumberEndResult = Triangle.itIsANumber(name, number, condition);
                itIsMoreThanZeroResult = Triangle.itIsMoreThanZero(itIsANumberEndResult);
                itISLessThanBillionResult = Triangle.itIsLessThanBillion(itIsANumberEndResult);


            }
            while ((itIsANumberEndResult == 0) || (itIsMoreThanZeroResult == 0) || (itISLessThanBillionResult == 0));
            this.a = itIsANumberEndResult;
        }
        public void setB()
        {
            string name = "B";
            string number = "2";
            string condition = "";
            int itIsANumberEndResult = 0;
            int itIsMoreThanZeroResult = 0;
            int itISLessThanBillionResult = 0;
            do
            {
                itIsANumberEndResult = Triangle.itIsANumber(name, number, condition);
                itIsMoreThanZeroResult = Triangle.itIsMoreThanZero(itIsANumberEndResult);
                itISLessThanBillionResult = Triangle.itIsLessThanBillion(itIsANumberEndResult);


            }
            while ((itIsANumberEndResult == 0) || (itIsMoreThanZeroResult == 0) || (itISLessThanBillionResult == 0));
            this.b = itIsANumberEndResult;
        }
        public void setC(int sum)
        {
            string name = "C";
            string number = "3";

            string condition = "\nДлина 3й стороны не должна быть больше чем сумма 1й и 2й стороны, т.е. < " + sum.ToString() + ".";
            int itIsANumberEndResult = 0;
            int itIsMoreThanZeroResult = 0;
            int itISLessThanBillionResult = 0;
            int itIsLessThanSumAAndB = 0;
            do
            {
                itIsANumberEndResult = Triangle.itIsANumber(name, number, condition);
                itIsMoreThanZeroResult = Triangle.itIsMoreThanZero(itIsANumberEndResult);
                itISLessThanBillionResult = Triangle.itIsLessThanBillion(itIsANumberEndResult);
                itIsLessThanSumAAndB = Triangle.itIsLessThanSumAAndB(itIsANumberEndResult, sum);

            }
            while ((itIsANumberEndResult == 0) || (itIsMoreThanZeroResult == 0) || (itISLessThanBillionResult == 0) || (itIsLessThanSumAAndB == 0));
            this.c = itIsANumberEndResult;
        }

        //NEGATIVE TESTS

        // It's number ?
        static int itIsANumber(string name, string number, string condition)
        {
            bool end = false;
            int n1 = 0;
            do
            {

                Console.WriteLine(number + ") Введите длину стороны " + name + ".\n(Значение длины должно быть целым числом от 1 до 1 000 000 000)" + condition);
                Console.Write("   " + name + "=");
                var result = int.TryParse(Console.ReadLine(), out int n);
                n1 = n;
                end = result;
                if (end == false)
                {
                    Console.WriteLine("Вы ввели текст или число с запятой, или число выходящее за рамки от 1 до 1 000 000 000, попробуйте снова,\nможет вам повезет. ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (end == false);
            return n1;
        }

        // The number not Negative
        static int itIsMoreThanZero(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Ваше число меньше или равное 0. Вернитесь к началу.");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            return n;
        }

        // The numbet less that 1 000 000 000;
        static int itIsLessThanBillion(int n)
        {
            if (n > 1000000000)
            {
                Console.WriteLine("Ваше число больше  1 000 000 000. Вернитесь к началу.");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            return n;
        }
        // The Sum A + B > C?
        static int itIsLessThanSumAAndB(int n, int sum)
        {
            if (n >= sum)
            {
                Console.WriteLine("Длина вашей третьей стороны больше суммы 1й и 2й стороны.\nПопробуйте еще раз.");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            return n;
        }

        // WHAT Is the triangle
        public int whatIsTheTriangle(int a, int b, int c)
        {
            if ((a == 0) || (b == 0) || (c == 0))
                return 0;
            if (((a + b) < c) || ((a + c) < b) || ((c + b) < a))
                return 0;
            if (((a + b) == c) || ((a + c) == b) || ((c + b) == a))
                return 0;



                if ((a == b) && (a == c) && (c == b))
            {
                Console.WriteLine("Ваш треугольник равностронний.");
                return 1;
            }
            else if ((a == b) || (b == c) || (a == c))
            {
                Console.WriteLine("Ваш треугольник равнобедренный.");
                return 2;
            }
            else
            {
                Console.WriteLine("Ваш треугольнак разностронний.");
                return 3;
            }
                return 0;
        }
    }
}

