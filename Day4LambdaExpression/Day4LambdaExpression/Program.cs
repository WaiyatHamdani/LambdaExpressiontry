using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Day4LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Trying single parameter lambda------------------");
            //the first int is for the parameter and the second int for the result
            Func<int, int> power3 = x => (int)Math.Pow(x,3);
            Console.WriteLine(power3(5));


            Console.WriteLine("-----------------Trying 2 parameter  lambda------------------");
            //the first and second int is for parameter and the third is for result
            Func<int, int ,int> multiplication = (z, y) =>  z * y;
            Console.WriteLine(multiplication(5,6));


            Console.WriteLine("-----------------Trying list lambda------------------");
            List<int> number = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> isevennum =  number.Where<int>(x => x % 2 == 0) ;

            foreach( int singlenum in isevennum)
            {
                Console.WriteLine(singlenum);
            }
           


        }
    }
}
