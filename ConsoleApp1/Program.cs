using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
    class Fraction
    {
        int numerator = 1;
        int denominator = 2;
        public Fraction(int num, int den)
        {
            numerator = num;
            denominator = den;
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 0;
        }
        public void SetFraction()
        {
            Write("Введите числитель дроби ");
            numerator = ToInt32(ReadLine());
            while (true)
            {
                Write("Введите знаменатель дроби ");
                denominator = ToInt32(ReadLine());
                if (denominator != 0)
                    break;
                else
                    WriteLine("Знаменатель введён не верно!");
            }
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2.numerator * f1.numerator;
            f3.denominator = f2.denominator * f1.denominator;
            return f3;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2.denominator * f1.numerator;
            f3.denominator = f2.numerator * f1.denominator;
            return f3;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2.numerator * f1.denominator + f1.numerator * f2.denominator;
            f3.denominator = f2.denominator * f1.denominator;
            return f3;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            f3.denominator = f2.denominator * f1.denominator;
            return f3;
        }
        public static Fraction operator *(Fraction f1, int f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2 * f1.numerator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator /(Fraction f1, int f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f1.numerator;
            f3.denominator = f2 * f1.denominator;
            return f3;
        }
        public static Fraction operator +(Fraction f1, int f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2 * f1.denominator + f1.numerator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator -(Fraction f1, int f2)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f1.numerator - f2 * f1.denominator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator *(int f2, Fraction f1)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2 * f1.numerator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator /(int f2, Fraction f1)
        {
            Fraction f3 = new Fraction();
            f3.denominator = f1.numerator;
            f3.numerator = f2 * f1.denominator;
            return f3;
        }
        public static Fraction operator +(int f2, Fraction f1)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2 * f1.denominator + f1.numerator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator -(int f2, Fraction f1)
        {
            Fraction f3 = new Fraction();
            f3.numerator = f2 * f1.denominator - f1.numerator;
            f3.denominator = f1.denominator;
            return f3;
        }
        public static Fraction operator *(double a, Fraction f)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = f.numerator * ToInt32(a);
            f1.denominator = f.denominator * k;
            return f1;
        }
        public static Fraction operator +(double a, Fraction f)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = ToInt32(a) * f.denominator + f.numerator * k;
            f1.denominator = k * f.denominator;
            return f1;
        }
        public static Fraction operator -(double a, Fraction f)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = ToInt32(a) * f.denominator - f.numerator * k;
            f1.denominator = k * f.denominator;
            return f1;
        }
        public static Fraction operator /(double a, Fraction f)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = f.denominator * ToInt32(a);
            f1.denominator = f.numerator * k;
            return f1;
        }
        public static Fraction operator *(Fraction f, double a)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = f.numerator * ToInt32(a);
            f1.denominator = f.denominator * k;
            return f1;
        }
        public static Fraction operator +(Fraction f, double a)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = ToInt32(a) * f.denominator + f.numerator * k;
            f1.denominator = k * f.denominator;
            return f1;
        }
        public static Fraction operator -(Fraction f, double a)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = f.numerator * k - ToInt32(a) * f.denominator;
            f1.denominator = k * f.denominator;
            return f1;
        }
        public static Fraction operator /(Fraction f, double a)
        {
            int k = 0;
            while (ToInt32(a) != a)
            {
                a *= 10;
                k += 10;
            }
            Fraction f1 = new Fraction();
            f1.numerator = k * f.numerator;
            f1.denominator = ToInt32(a) * f.denominator;
            return f1;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            float fi = f1.numerator / f1.denominator;
            float fii = f2.numerator / f2.denominator;
            if (fi < fii)
                return true;
            else
                return false;
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            float fi = f1.numerator / f1.denominator;
            float fii = f2.numerator / f2.denominator;
            if (fi > fii)
                return true;
            else
                return false;
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            float fi = f1.numerator / f1.denominator;
            float fii = f2.numerator / f2.denominator;
            if (fi == fii)
                return true;
            else
                return false;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            float fi = f1.numerator / f1.denominator;
            float fii = f2.numerator / f2.denominator;
            if (fi != fii)
                return true;
            else
                return false;
        }
        public static bool operator true(Fraction f)
        {
            if (f.numerator < f.denominator)
                return true;
            return false;
        }
        public static bool operator false(Fraction f)
        {
            if (f.numerator > f.denominator)
                return true;
            return false;
        }
        public void simp()
        {
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            if (denominator > numerator)
            {
                for (int i = 1; i < denominator / 2 + 2; i++)
                    if (denominator % i == 0 && numerator % i == 0)
                    {
                        denominator /= i;
                        numerator /= i;
                    }
            }
            else
            {
                for (int i = 1; i < numerator / 2 + 2; i++)
                    if (denominator % i == 0 && numerator % i == 0)
                    {
                        denominator /= i;
                        numerator /= i;
                    }
            }
        }
        public void print()
        {
            simp();
            WriteLine($"{numerator}/{denominator}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 54);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();
            f2.SetFraction();
            Write("f1 = ");
            f1.print();
            Write("f2 = ");
            f2.print();
            f3 = f1 / f2;
            Write("f1 / f2 = ");
            f3.print();
            f3 = f1 * f2;
            Write("f1 * f2 = ");
            f3.print();
            f3 = f1 + f2;
            Write("f1 + f2 = ");
            f3.print();
            f3 = f1 - f2;
            Write("f1 - f2 = ");
            f3.print();
            if (f2 == f1)
                WriteLine("f2 == f1");
            if (f2 != f1)
                WriteLine("f2 != f1");
            if (f2 > f1)
                WriteLine("f2 > f1");
            if (f2 < f1)
                WriteLine("f2 < f1");
            if (f2)
                WriteLine("Дробь f2 правильная");
            else
                WriteLine("Дробь f2 неправильная");
            f3 = f2 * 10;
            Write("f2 * 10 = ");
            f3.print();
            f3 = 10 - f2;
            Write("10 - f2 = ");
            f3.print();
            f3 = 1.5 + f2;
            Write("1.5 + f2 = ");
            f3.print();
            f3 = f2 / 1.8;
            Write("f2 / 1.8 = ");
            f3.print();
        }
    }
}