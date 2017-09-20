using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;
namespace Csharp60New
{
    class Topic_8
    {
        public string FirstName { get; set; }

        public void Entry()
        {
            try
            {
                if (IsNullOrEmpty(FirstName))
                {
                    throw new ArgumentNullException(message: "can not be blank", paramName: nameof(FirstName)); //Named Arguments :c# 4.0
                }
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
