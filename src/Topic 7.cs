using System;

namespace Csharp60New
{
    class Topic_7
    {
        public void Entry()
        {
            TestExceptionFilter();
        }

        public void TestExceptionFilter()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (System.Exception e) when(e.Message.Contains("object")&&System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
