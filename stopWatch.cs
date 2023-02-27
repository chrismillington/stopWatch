using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopWatch
{
    public class stopWatch
    {
        public stopWatch() {

            while(true)
            {
                Console.WriteLine("Stopwatch");
                Console.WriteLine("Press any key and enter to being and stop to finish");
                string startStop = Console.ReadLine();
                DateTime start = DateTime.Now;
                startStop = Console.ReadLine();
                DateTime stop = DateTime.Now;
                Console.WriteLine(stop - start);
            }


        }
        
    }
}
