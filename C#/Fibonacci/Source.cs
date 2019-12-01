using System;

namespace Fibb
{
    class program{
        static void Main(string[] args){
            int a=0;
            int b=1;
            int c=0;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(a+"\n"+b);
            for(int i=2;i<number;i++){
                c=a+b;
                Console.WriteLine(c);
                a=b;
                b=c;
            }
            Console.ReadKey();
        }
    }
}

