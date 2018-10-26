﻿using System;
using System.Collections.Generic;

//todo: test error management
//todo: program should take args. first expr: steps: etc foreach str

namespace ComputorV1
{
    //"0"
    //"0 = 0"
    //"0 = 0 = 0"
    //"= 0"
    //"2 = 0"
    //"x =2,0"
    //"X =2.0"
    //"x^20 = 0"
    //"x^20 = x^20"
    //"2*x=2*X"
    //"2 + 1 * x^2 = 0"
    //"1 * x ^0 + 0 * x^1 + 1 * x^2 = 0"
    //"1 * x ^0 + 0 * x^1 - 1 * x^2 = 0"
    //"x^2 - x - 2 = 0"
    //"x^2 + x - 2 = 0"
    //"x^2 + 4*x + 4 = 0"
    //"x^2 - 6*x + 34=0"
    //"2 + ----3 * x ^2 = 0"

    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                List<double> polynomial = Polynomial.Parse("1 * x ^0 + 0 * x^1 = -1 * x^2 ");
                Polynomial.ShortenCoef(polynomial);
                Console.Write("Reduced form: ");
                Console.Write(Polynomial.ToString(polynomial));
                Console.WriteLine(" = 0");
                Console.WriteLine("Degree: " + (polynomial.Count - 1));
                if (polynomial.Count > 3)
                    throw new Exception(String.Format("Degree has to be 0..2. {0} is not.", polynomial.Count - 1));
                Polynomial.Solve(polynomial);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            return 0;
        }
    }
}
