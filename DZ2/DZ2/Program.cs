//Дз 2  -  Буй Тхе Зунг  -  УТС22  -  Вариант 2
using System;
using m = System.Math;

namespace DZ2
{
    class Program
    {
        //y = 0.6 * x + 1.8
        static double segment1(double x)
        {
            double y = 0.6 * x + 1.8;
            return y;
        }

        //x^2 + y^2 = R^2                                                          
        static double segment2(double x, double r)
        {
            double y = m.Sqrt(m.Pow(r, 2) - x * x);
            return -y;
        }

        //y = x - 3
        static double segment3(double x)
        {
            double y = x - 3;
            return y;
        }

        //Funstion show result on screen
        // 2 situation:
        //             1. R>=3
        //             2. R<3
        static void show(double a, double b, double c, double r, bool checkValid)
        {
            for (double x = -10.00; x <= 8.20; x += 0.20)
            {
                x = m.Round(x, 2);
                // When R>3 or R==3  - checkValid=false 
                if (checkValid == false)
                {
                    if (x <= -8)
                    {
                        if (x == -8)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, -3);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -3);
                        }
                    }
                    if (x >= -8 && x <= a)
                    {
                        if (x == -8)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, segment1(x));
                        }
                        else if (x == a)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, segment1(x));
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                        }
                    }
                    if (x > a && x < b)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r));
                    }

                    if (x == a || x == b)
                    {
                        if (x == a)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, 0);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, 0);
                        }
                    }
                    if (x >= b && x <= c)
                    {
                        if (x == b)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, segment3(x));
                        }
                        else if (x == c)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, segment3(x));
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                        }
                    }
                    if (x >= c && x <= 8)
                    {
                        if (x == c)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, 3);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, 3);
                        }
                    }
                }
                //When R<3 - checkValid=true
                else if (checkValid == true)
                {
                    if (x <= -8)
                    {
                        if (x == -8)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, -3);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -3);
                        }
                    }
                    if (x >= -8 && x <= -3.00)
                    {
                        if (x == -3)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, 0);
                        }
                        else if (x == -8)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, segment1(x));
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                        }
                    }
                    if (x >= -3 && x <= -r)
                    {
                        if (x == -3)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = Unknown!(Because R < 3)", x);
                        }
                        else if (x == -r)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = Unknown!(Because R < 3)", x);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = Unknown!(Because R < 3)", x);
                        }
                    }
                    if (x > -r && x < r)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r));
                    }
                    if ((x == r) || (x == -r))
                    {
                        if (x == -r)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, 0);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, 0);
                        }
                    }
                    if (x >= r && x <= 3)
                    {
                        if (x == r)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = Unknown!(Because R < 3)", x);
                        }
                        else if (x == 3)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = Unknown!(Because R < 3)", x);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = Unknown!(Because R < 3)", x);
                        }
                    }
                    if (x >= 3 && x <= 5)
                    {
                        if (x == 3)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, 0);
                        }
                        else if (x == 5)
                        {
                            Console.WriteLine("y({0:0.00}(-)) = {1:0.00}", x, segment3(x));
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                        }
                    }
                    if (x >= 5 && x <= 8)
                    {
                        if (x == 5)
                        {
                            Console.WriteLine("y({0:0.00}(+)) = {1:0.00}", x, 3);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, 3);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bui The Zung - UTS22 - Question 2");
            double r, a = 0, b = 0, c = 0;
            bool checkValid = false; //checkValid=false When R>=3 ;   checkValid=true  When R<3

        //In Question 2 - the range of figure from -10 -> 8 and the center of circumference is(0;0)
        //       => the Radius of circumference have to be 0<R<8. Because if R>8, the limit of circumference in X-axis will exceed the range of figure

        //Condition for the input value R : - Have to be a number (0<R<8)
        inputProcess:
            try
            {
                Console.Write("Enter Radius R (0 -> 8) = ");
                r = Convert.ToDouble(Console.ReadLine());
                if (r > 8)
                {
                    Console.WriteLine("Sorry!\nThe Radius R should be a value between 0 and 8 !");
                    goto inputProcess;
                }
                else if (r < 0)
                {
                    Console.WriteLine("Sorry!\nThe Radius R should be a positive number!");
                    goto inputProcess;
                }
            }
            catch (FormatException E)
            {
                Console.WriteLine("Sorry !\nThe Number Format Exception : {0}.\nPlease enter a number\n", E.Message);
                goto inputProcess;
            }


            // a, b ,c is the range of each equation will be changed when R> 3
            //When 5 <= R <= 8 : The firgure will be :
            //  -10 -> -8   ||   -8 -> a   ||    a -> b    ||  b -> c  ||  c->8
            //     y=-3     || y=0.6*x+1.8 ||  x^2+y^2=R^2 ||    y=3   ||  y=3
            if (r >= 5 && r <= 8)
            {
                a = -r;
                b = r;
                c = r;
                checkValid = false;
            }
            //When 3 < R < 5 : The firgure will be :
            //  -10 -> -8   ||   -8 -> a   ||    a -> b    ||  b -> c  ||  c->8
            //     y=-3     || y=0.6*x+1.8 ||  x^2+y^2=R^2 ||   y=x-3  ||  y=3
            else if ((r > 3 && r < 5) || (r == 3))
            {
                a = -r;
                b = r;
                c = 5;
                checkValid = false;
            }
            //When R < 3 : The firgure will be :
            //  -10 -> -8   ||   -8 -> -3   ||   -3 -> a  ||    a -> b    ||   b->3   ||  3 -> c(c=5)  ||  5->8
            //     y=-3     || y=0.6*x+1.8  ||  Unknown   ||  x^2+y^2=R^2 ||  Unknown ||     y=x-3     ||  y=3
            else if (r < 3)
            {
                a = -r;
                b = r;
                c = 5;
                checkValid = true;
            }
            show(a, b, c, r, checkValid);
            Console.ReadKey();
        }
    }
}
