using System;
namespace _CNG__Calculator
{

    public class basic
    {

        public double sum(double a, double b)
        {
            return a + b;
        }

        public double difference(double a, double b)
        {
            return a - b;
        }

        public double multiplication_of_numbers(double a, double b)
        {
            return a * b;
        }

        public double quotient(double a, double b)
        {
            return a / b;
        }

        public double root_of_number(double a)
        {
            return Math.Sqrt(a);
        }

        public double degree_num(double a, double b)
        {
            return Math.Pow(a, b);
        }

    }
}
