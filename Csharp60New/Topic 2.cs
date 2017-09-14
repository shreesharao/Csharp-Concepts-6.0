using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    
    class Topic_2
    {
        public string FirstName { get; set; } = "Shreesha";
        public List<string> LstNames { get; } = new List<string>();

        public void Entry()
        {
            LstNames.Add("Shreesha");
            LstNames.Add("Rao");
            Console.WriteLine($"FirstName:{FirstName}");
            LstNames.ForEach(el => Console.WriteLine(el));
        }
    }
}
