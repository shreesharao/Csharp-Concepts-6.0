using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_5
    {
        Topic_5_Test obj;
        public void Entry()
        {
            var propValue = obj?.MyProperty;
            Console.WriteLine($"propValue :{propValue?? "propValue is null"}");  //null
            Console.WriteLine($"propValue :{propValue?.GetType()}");  //null
            obj?.Test();
        }
    }

    class Topic_5_Test
    {
        public string MyProperty { get; } = "Test";
        public void Test()
        {
            Console.WriteLine("Test Message");
        }
    }
}
