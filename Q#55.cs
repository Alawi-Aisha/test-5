using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3 , b=4;
            ++a = b++;
            
        //(a)
            Console.WriteLine(a);

        //(b)
            //If we replace ++a = b++ by "++a=++b"
            Console.WriteLine(a);

        //(c)
            a=a+1;
            b=b+1;
            a=a*b;
        }
    }
}