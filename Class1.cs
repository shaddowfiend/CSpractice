using System;
using System.Globalization;

public class ProblemW
{
    public ProblemW()
	{
       
	}

	public void Problema1()
	{
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (num>=i)
        {
            num /= 10;
            i++;
        }
        Console.WriteLine(i);
    }
    public void Problema2()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        while (num>0)
        {
            fact *= num;
            num--;
        }
        Console.WriteLine(fact);
    }
    public void Problema3()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num>=0)
        {
            if (num%2==0)
            {
                sum += num;
            }
            num--;
        }
        Console.WriteLine(sum);
    }
    public void Problema4()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num >= 0)
        {
            if (num % 2 != 0)
            {
                sum += num;
            }
            num--;
        }
        Console.WriteLine(sum);
    }
    public void Problema5()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        while (n>0)
        {
            a *= 10;
            n--;
        }
        Console.WriteLine(a);
    }
    public void Problema6()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        while (num / 2 > i)
        {
            i++;
            if (num % i == 0)
            {
                Console.WriteLine("Numarul nu este prim");
                break;
            }
            else
                {
                Console.WriteLine("Numarul este prim");
                break;
            }
        }
    }
    public void Problema7()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int min = Math.Min(a, n);
        while (min>0) 
        {
            if (a % min == 0 && n % 2 == 0)
            {
                Console.WriteLine("Cel mai mare divizor comun este" + min);
                break;
            }
            min--;
        }
    }
    public void Problema8()
    {   //neterminat
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int min = Math.Min(a, n);
        while (min > 0)
        {
            if (a % min == 0 && n % 2 == 0)
            {
                Console.WriteLine("Cel mai mare divizor comun este" + min);
                break;
            }
            min--;
        }
    }
    public void Problema9()
    {
        int sumpar = 0, sumimp = 0;
        int i = 0;
        while(i <= 10)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                sumpar += number;
            }
            if (number % 2 != 0)
            {
                sumimp += number;
            }
            if (number == 0)
            {
                break;
            }
            i++;
        }
        Console.WriteLine("Suma nr pare:" + sumpar);
        Console.WriteLine("Suma nr impare:" + sumimp);
    }
    public void Problema10()
    {
        int sum = 0;
        int i = 0;
        while( i <= 10)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0)
            {
                sum += number;
            }
            if (number == 0)
            {
                break;
            }
            i++;
        }
        Console.WriteLine("Suma nr: " + sum);
    }
    public void Problema11()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while(i <= 10)
        {
            Console.WriteLine(i + " * " + n + " = " + n * i);
            i++;
        }
    }
    public void Problema12()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
    public void Problema13a()
    {
        int z = 1,i = 1;
        int l = Convert.ToInt32(Console.ReadLine());
        int L = Convert.ToInt32(Console.ReadLine());
        while(i <= L)
        {
            int j = 1;
            while (j <= l)
            {
                Console.Write(z);
                j++;
            }
            z++;
            i++;
            Console.WriteLine();
        }
    }
    public void Problema13b()
    {
        int z = 1,i = 1;
        int l = Convert.ToInt32(Console.ReadLine());
        int L = Convert.ToInt32(Console.ReadLine());
        while ( i <= L)
        {
            int j = 1;
            while(j <= l)
            {
                Console.Write(z);
                z++;
                j++;
            }
            Console.WriteLine();
            z = 1;
            i++;
        }
    }
    public void Problema14()
    {

    }
    public void Problema15a()
    {
        int i = 1;
        int num = Convert.ToInt32(Console.ReadLine());
        while (i <= num)
        {
            int j = 1;
            while (j <= num - (num - i))
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }
    public void Problema15b()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int i = num;
        while (i >= 0)
        {
            int j = 1;
            while ( j <= num)
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            num--;
            i--;
        }
    }
}