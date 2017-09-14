using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_3
    {
        public string FName { get; set; } = "Shreesha";
        public string LName  => "Rao";

        public string FullName => $"{FName} {LName}";

        public void Entry() => Console.WriteLine($"FullName:{FullName}");
    }
}
