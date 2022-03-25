using System;

namespace ConsoleApp1
{

    delegate void MyDelegate(int num1,int num2);

    internal class Program
    {
        static void Main(string[] args)
        {

            MyDelegate myDelegate = new MyDelegate(Sum);
            myDelegate += Multiply;
            myDelegate.Invoke(50,91);



                Console.ReadLine();
        }

        static void Sum(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }

        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
    }
}