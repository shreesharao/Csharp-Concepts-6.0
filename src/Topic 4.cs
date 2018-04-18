using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Csharp60New.MyMath;
using static System.String;

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
        }

    }

    class MyMath
    {
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Multiply(int num1, int num2) => num1 * num2;
        public int Divide(int num1, int num2) => num1 / num2;
    }


}
