using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_10
    {
        private Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            [404] = "Not found",
            [500] = "Internal server error",
            [200] = "success"
        };
        public void Entry()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }         
        }
    }
}
