using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Csharp60New.MyMath;
using static System.String;
using static Csharp60New.Topic_4Extension; //this is not required

namespace Csharp60New
{

    class Topic_4
    {
        public void Entry()
        {
            Console.WriteLine(new MyMath().Divide(1, 2));

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(IsNullOrEmpty("Shreesha"));

            //extension method call
            //Subtract();       //it is not possible to call it as static method
            new Topic_4().Subtract(10, 5);

            //Divide method must be called like this
            new MyMath().Divide(10, 5);

        }

    }

    class MyMath
    {
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Multiply(int num1, int num2) => num1 * num2;
        public int Divide(int num1, int num2) => num1 / num2;
    }

    //extension method
    static class Topic_4Extension
    {
        public static int Subtract(this Topic_4 topic_4, int num1, int num2) => num1 - num2;
    }


}
