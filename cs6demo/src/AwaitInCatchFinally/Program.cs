using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AwaitInCatchFinally
{
    public class Program
    {
        public async Task Main(string[] args)
        {
            var logger = new Logger();

            try
            {
                using (var stream = File.OpenWrite("outp.txt"))
                {
                    var bytes = Encoding.UTF8.GetBytes("Banan");
                    await stream.WriteAsync(bytes, 0, bytes.Length);

                    throw new Exception("Unexpected exception");
                }
            }
            catch(Exception ex)
            {
                // New in C# 6
                await logger.Error(ex);
            }
        }
    }

    class Logger
    {
        public async Task Error(Exception ex)
        {
            using (var log = new StreamWriter(File.OpenWrite("err.log")))
            {
                await log.WriteLineAsync(ex.ToString());
            }
        }
    }
}