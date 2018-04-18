using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_9
    {
        public void Entry()
        {
            LogAsync();
            Console.WriteLine(value: $"out of {nameof(LogAsync)} method");
        }

        private async void LogAsync()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                await WriteAsync(message: ex.Message);
                return;
            }
            finally
            {
                await WriteAsync(message: "Finally block reached");
            }
        }

        private async Task<int> WriteAsync(string message)
        {
            await Task.Delay(1000);
            Console.WriteLine(message);
            return 0;
        }
    }
}
