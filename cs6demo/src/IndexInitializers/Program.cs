using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexInitializers
{
    public class Program
    {
        public void Main(string[] args)
        {
            var cs5 = new Dictionary<int, string>
            {
                { 42, "???" },
                { 33, "???" },
            };

            var cs5strkey = new Dictionary<string, string>
            {
                { "42", "???" },
                { "33", "???" },
            };

            /*
            var cs6 = new Dictionary<int, string>
            {
                [42] = "???",
                [33] = "???",
            };

            var cs6str = new Dictionary<string, string>
            {
                ["42"] = "???",
                ["33"] = "???",
            };
            */
        }
    }
}
