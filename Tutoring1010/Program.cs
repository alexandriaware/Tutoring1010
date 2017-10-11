using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;

            for (hours = 0; hours < 13; hours++)
            {
                for (minutes = 0; minutes < 60; minutes++)
                {
                    for (seconds = 0; seconds < 60; seconds++)
                    {
                        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }

        }
    }
}
