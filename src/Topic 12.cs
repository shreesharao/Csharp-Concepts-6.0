using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_12
    {
        public void Entry()
        {
            Task.Run(PrintMessage);
        }

        static Task PrintMessage()
        {
            Console.WriteLine($"from {nameof(PrintMessage)}Improved overload resolution");
            return Task.FromResult(0);
        }
    }


}
