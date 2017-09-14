using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_6
    {
        public string FirstName { get; set; } = "Shreesha";
        public string LastName { get; set; } = "Rao";

        public string FullName => $"{FirstName} {LastName}";
        public void Entry()
        {
            Console.WriteLine($"FullName {FullName}");
        }
    }
}
