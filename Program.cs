using System;

internal class Program
{
    private static void Main(string[] args)
    {
        BiArray.Arro();
    }
    public static void Prob1()
    {
        int i;
        int num = Convert.ToInt32(Console.ReadLine());
        for (i = 0; num>0 ; i++)
        { 
            num /= 10;
        }
        Console.WriteLine(i);
    }
    public static void Prob2()
    {
        int factorial = 1;
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
    public static void Prob3()
    {
        int sum = 0;
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i%2==0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    public static void Prob4()
    {
        int sum = 0;
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    public static void Prob5()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            a *= 10;
        }
        Console.WriteLine(a);
    }
    public static void Prob6()
    {
        
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= number / 2; i++)
        {
            if(number % i == 0)
            {
                Console.WriteLine("Numarul " + number + " nu este prim");
                break;
            }
            else
            {
                Console.WriteLine("Numarul " + number + " este prim");
                break;
            }
        } 
    }
    public static void Prob7()
    {
        // neterminata
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int min = Math.Min(a, n);
        for (int i = min; i < min; i--)
        {
            if (a % i == 0 && n % i == 0)
            {
                Console.WriteLine("Cel mai mare divizor comun este " + i);
                break;
            }
            else
            {
                continue;
            }
        }
    }
    public static void Prob8()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int res = 1;
        for (int i = 2; i < Math.Min(a, n); i++)
        {
            if (a % i == 0 && n % i == 0)
            {
                res = i;
                break;
            }
        }
        Console.WriteLine(res);
    }
    public static void Prob9()
    {

        int sumpar = 0, sumimp=0;
        for (int i = 0; i <= 10; i++)
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
        }
        Console.WriteLine("Suma nr pare:" + sumpar);
        Console.WriteLine("Suma nr impare:" + sumimp);
    }
    public static void Prob10()
    {
        int sum = 0;
        for (int i = 0; i <= 10; i++)
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
        }
        Console.WriteLine("Suma nr: "+ sum);
    }
    public static void Prob11()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " * " + n + " = " + n*i);
        }
    }
    public static void Prob12()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void Prob13a()
    {
        int z = 1;
        int l = Convert.ToInt32(Console.ReadLine());
        int L = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= L; i++)
        {
            for (int j = 1; j <= l; j++)
            {
                Console.Write(z);
                
            }
            z++;
            Console.WriteLine();
        }
    }
    public static void Prob13b()
    {
        int z = 1;
        int l = Convert.ToInt32(Console.ReadLine());
        int L = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= L; i++)
        {
            for (int j = 1; j <= l; j++)
            {
                Console.Write(z);
                z++;
            }            
            Console.WriteLine();
            z = 1;
        }
    }
    public static void Prob14()
    {
        // neterminata
        int num = Convert.ToInt32(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        for (int i = 1; i <= 2 * num - 1; i += 2)
        {
            sum1 += i;
        }
        for (int i = 1; i < 2 * num - 1; i += 2)
        {
            sum2 += i;
        }
        for (int i = 2; i <= num * 2; i += 2)
        {
            sum3 += i;
        }
        for (int i = 1; i <= (num - 1) * num; i++)
        {
            sum4 = sum4 + i * i++;
        }
        Console.WriteLine(sum4 + sum3 + sum2 + sum1);
    }
    public static void Prob15a()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num-(num-i); j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public static void Prob15b()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = num; i >= 0; i--)
        {
            for (int j = 1; j <= num ; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            num--;
        }
        
    }
    public static void Prob16()
    {
        //neterminat
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public static void Prob17()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
    public static void Prob18()
    {
        Console.WriteLine("Introduceţi valoarea lui k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        int count = 0;

        for (int i = 0; suma <= k; count++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            i += n;
            if (n % 2 == 0)
            {
                suma += n;
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(suma);
    }
    public static void Prob19()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.WriteLine();
        }
    }
    public static void Prob20()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }
            for (int j = num - i*2 + num; j > 1; j--)
            {
                Console.Write(num - i);
            }
            Console.WriteLine();
        }
    }
    public static void Prob21()
    {

        int suma = 0;
        int max = 0, min = 1000;
        for (int i = 0; suma < 1000; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            suma += n;
            if (n > max)
            {
                max = n;
            }
            if (n < min)
            {
                min = n;
            }
        }
        Console.WriteLine("max=" + max+"\nmin=" + min);
    }   
}
class Arrays
{
    public static void Arra()
    {
        int[] arr = {5,4,5,2,7,6,5};
        foreach (int i in arr)
        {
            System.Console.Write($"{i} ");
        }
    }
    public static void Arrb(){
        int[] arr = {5,4,5,2,7,6,5};
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            System.Console.Write($"{arr[i]} ");
        }
    }
    public static void Arrc(){
        int[] arr = {5,4,5,2,7,6,5};
        for (int i = 0; i <= arr.Length/2; i++)
        {
            System.Console.Write($"{arr[i]}{arr[(arr.Length-1)-i]}");
        }
    }
    public static void Arrd(){
        int[] arr = {5,4,5,2,7,6,5};
        int min = 10,max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
                min = arr[i];
            }
        }
        System.Console.WriteLine($"{min} {max}");
    }
    public static void Arre(){
        int[] arr = {5,4,5,2,7,6,5};
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
            }
        }
        System.Console.WriteLine(sum);
    }
    public static void Arrf(){
        int[] arr = {5,4,5,2,7,6,5};
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += arr[i];
            }
        }
        System.Console.WriteLine(sum);
    }
    public static void Arrg(){
        int[] arr = {5,4,5,2,7,6,5};
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
    }
    public static void Arrh(){
        int[] arr = {5,4,5,2,7,6,5};
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.Write($"{arr[i]} ");
            }
        }
        System.Console.WriteLine();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                System.Console.Write($"{arr[i]} ");
            }
        }
    }
    public static void Arri(){
        int[] arr = {5,4,5,2,7,6,5};
        int min = 10,max = 0,num = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
                min = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == max-min)
            {
                num++;
            }
        }
        System.Console.WriteLine(num);
    }
    public static void Arrj(){
        int[] arr = {5,4,5,2,7,6,5};
        double med,sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        med = sum / arr.Length;
        System.Console.WriteLine((double)med);
    }
    public static void Arrk(){
        int[] arr = {5,4,5,2,7,6,5};
        int sum = 0,num = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
                num++;
            }
        }
        System.Console.WriteLine(sum/num);
    }
    public static void Arrl(){
        int[] arr = {5,4,5,2,7,6,5};
        int min = 10,max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
                min = arr[i];
            }
        }
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] != max && arr[j] != min)
            {
                System.Console.WriteLine(arr[j]);
            }
        }
    }
    public static void Arrm()
    {
        int[] arr = {5,4,5,2,7,6,5};
        foreach (int i in arr)
        {
            System.Console.Write($"{i+10} ");
        }
    }
    public static void Arrn(){
        int[] arr = {5,4,5,2,7,6,5};
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                System.Console.Write(arr[i]*2 + " ");
            }
            if(arr[i] % 2 != 0){
            System.Console.Write(arr[i]*3 + " ");
            }
        }
    }
    public static void Arro(){
        int[] arr = {5,4,5,2,7,6,5};
        int min = 10,max = 0,buffer;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
                min = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==min)
            {
                
                buffer = arr[0];
                arr[0] = min;
                arr[i] = buffer;
            }
            if (arr[i]==max)
            {
                buffer = arr[arr.Length-1];
                arr[arr.Length-1] = max;
                arr[i] = buffer;
            }
        }
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }
    public static void Arrp()
    {
        //neterminata
        int[] arr = {5,4,5,4,7,6,5};
        int diff = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                
            }
        }
            System.Console.WriteLine(diff);
    }
}
class BiArray{
        public static void Arrk(){
            int[,] arr ={{1,2,3},
                         {4,5,6},
                         {7,8,9}};
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, arr.GetLength(1)- 1 - i];
                System.Console.WriteLine(arr[i, arr.GetLength(1) - 1 - i]);
            }
            System.Console.WriteLine($"Suma = {sum}");
        }
        public static void Arrl(){
            int[,] arr ={{1,2,3},
                         {4,5,6},
                         {7,8,9}};
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0)-1; i++)
            {
                sum += arr[i,i+1];
                System.Console.WriteLine(arr[i,i+1]);
            }
            System.Console.WriteLine($"Suma = {sum}");
        }
        public static void Arrm(){
            int[,] arr ={{1,2,3},
                         {4,5,6},
                         {7,8,9}};
            int sum = 0;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                sum += arr[i,i-1];
                System.Console.WriteLine(arr[i,i-1]);
            }
            System.Console.WriteLine($"Suma = {sum}");
        }
        public static void Arrn(){
            int[,] arr ={{1,2,3},
                         {4,5,6},
                         {7,8,9}};
            int sum = 0;
            // 0 1 1 0
            for (int i = 0; i < arr.GetLength(0)-1; i++)
            {
                sum += arr[i, arr.GetLength(1)- 2 - i];// 0 2 1 1
                System.Console.WriteLine(arr[i, arr.GetLength(1)- 2 - i]);
            }
            System.Console.WriteLine($"Suma = {sum}");
        }
        public static void Arro(){
            int[,] arr ={{1,2,3},
                         {4,5,6},
                         {7,8,9}};
            int sum = 0;
            // 1 2 2 1
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                sum += arr[i, arr.GetLength(1) - i];// 0 1 1 0
                System.Console.WriteLine(arr[i, arr.GetLength(1) - i]);
            }
            System.Console.WriteLine($"Suma = {sum}");
        }
}