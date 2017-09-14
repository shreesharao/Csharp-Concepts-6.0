using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_1
    {
        //In c# 5.0 we used to get this error
        //Error	1	'ConsoleApplication1.Program.MyProperty.get' must declare a body because it is not marked abstract or extern.
        //Automatically implemented properties must define both get and set accessors.
        public string ReadOnlyProperty { get; }  //read only proerties can only be assigned inside constructor

        public Topic_1()
        {
            ReadOnlyProperty = "Test Message";
        }

        public void Entry()
        {
            //ReadOnlyProperty = "Test Again";
            Console.WriteLine($"ReadOnlyProperty:{ReadOnlyProperty}");
        }
    }
}
