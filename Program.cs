namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fibonachi

            //int n = int.Parse(Console.ReadLine());

            //int first = 0;
            //int second = 1;
            //int res = 0;

            //if (n == 0)
            //{
            //    Console.WriteLine(res);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine(res);
            //    }

            //    first = second;
            //    second = res;
            //    res = first + second;

            //    Console.WriteLine(res);
            //}


            // reverse number


            //int n = int.Parse(Console.ReadLine());

            //int tmp = n;
            //int rev = 0;
            //int k = 1;

            //while (tmp != 0)
            //{
            //    k *= 10;
            //    tmp /= 10;
            //}
            //k /= 10;
            //tmp = n;

            //while (tmp != 0)
            //{
            //    rev += (tmp % 10) * k;
            //    tmp /= 10;
            //    k /= 10;
            //}

            //Console.WriteLine(rev);



            //sum of digits


            //int n = int.Parse(Console.ReadLine());
            //int res = 0;
            //int tmp = n;

            //while (tmp != 0)
            //{
            //    res += tmp % 10;
            //    tmp /= 10;
            //}

            //Console.WriteLine(res);







            //Multiplication Table

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n} * {i} = " + (n * i));
            //}






            //Prime Number Checker


            //int n = int.Parse(Console.ReadLine());
            //bool isPrime = true;

            //for (int i = 2; i < (n / 2); i++) {
            //    if (n % i == 0)
            //    {
            //        isPrime = false;
            //    }
            //}

            //Console.WriteLine(isPrime);






            //Number Pyramid

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}


            //If N is even → N = N / 2
            //If N is odd → N = 3 * N + 1



            //Collatz Conjecture

            int n = int.Parse(Console.ReadLine());

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                } else
                {
                    n = 3 * n + 1;
                }
            }

            Console.WriteLine(n);





            //Finding the Longest Word in a Sentence
            //string sentence = Console.ReadLine();



        }
    }
}









