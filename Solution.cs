﻿using System;
using System.Collections.Generic;
using ComputorV1.Console;

namespace ComputorV1
{
    public class Solution
    {
        public string Expression { get; set; }
        
        public string ValidationError { get; set; }
        public bool IsValid => String.IsNullOrEmpty(ValidationError);
        
        public string ReducedForm { get; set; }
        public int Degree { get; set; }
        public bool IsSolvable => String.IsNullOrEmpty(ErrorMessage) && IsValid;

        public string ErrorMessage
        {
            get
            {
                if (Degree > 2 || Degree < 0)
                    return $"Expected degree: 0..2. Actual degree: {Degree}";
                return "";
            }
        }

        public SolutionType SolutionType { get; set; }

        public List<string> Answers { get; set; }

        public Solution()
        {
            Degree = -1;
            ValidationError = "";
            Answers = new List<string>();
        }

        public void WriteSolution(IConsole console)
        {
            console.WriteLine($"Expression: {Expression}");

            console.WriteLine($"Reduced form: {ReducedForm} = 0");
            console.WriteLine($"Polynomial Degree: {Degree}");
            if (IsSolvable)
            {
                SolutionPrinter.Print(this, console);
            }
            else
            {
                console.WriteLine(ErrorMessage);
            }
        }

        #region SolutionPrinters

        private void PrintSolution_None() { }

        private void PrintSolution_Single()
        {

            //Console.WriteLine("Solution:\nX = {0}", (-coefficients[0] / coefficients[1]));
        }
        private void PrintSolution_Doulbe() { }

        private static void PrintSolution_All(Solution solution)
        {

        }

        #endregion SolutionPrinters

    }
}