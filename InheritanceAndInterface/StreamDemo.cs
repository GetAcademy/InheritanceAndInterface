using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterface
{
    class StreamDemo
    {
        public static void Run()
        {
            var webClient = new WebClient();
            var stream = webClient.OpenRead("https://www.getacademy.no");
        }
    }
}
