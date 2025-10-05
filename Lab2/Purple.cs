using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            for (int i = 0; i < n; i++) {
                answer += (p + i * h)*(p + i * h);
            }
            return answer;



        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = a;

            while (remainder >= b)
    {
        remainder -= b;
        quotient+=1;
    }

            return (quotient, remainder);
        }
        public double Task3()
        {
           

            int a1 = 2, a2 = 3;
            int b1 = 1, b2 = 2;
            double current = (double)a2 / b2;
            double prev = (double)a1 / b1;
            while (true)
            {
                int a3 = a1 + a2;
                int b3 = b1 + b2;
                double next = a3 / b3;
                if (Math.Abs(next - current) < E)
                {
                    break;
                };
                    

                a1 = a2; a2 = a3;
                b1 = b2; b2 = b3;
                prev = current;
                current = next;
                
            };

            return current;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            for (double i = 1; Math.Abs(b * q * i) > E; i *= q)
            {
                answer += 1;
            }
            return answer+1;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while(number >= 10)
                {
                    number /= 10;
                    answer++;
                }
            return answer;
            

        }
        public long Task6()
        {
            BigInteger answer = 1;
            for (int i = 0; i < 64; i++)
            {
                answer *= 2;
            }
            answer -= 1;
            double res = (double) answer / 15_000_000.0;
            return (long)Math.Floor(res);
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
        double currentSum = S;
        double initialS = S;
        double m = d / 1200.0;

        while (currentSum < 2 * initialS)
    {
        currentSum += currentSum * m;
        answer++;
    }

    return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b; x += h)
    {
        double S = 0;
        double term = 1; 
        int i = 0;

        while (Math.Abs(term) >= 0.0001)
        {
            S += term;
            i++;
            term = term * (-1) * x * x / ((2 * i - 1) * (2 * i));
        }

        SS += S;
        SY += Math.Cos(x);
    }
        
            return (SS, SY);
        }
    }
}