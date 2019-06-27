using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NTSB
{
     class Database
     {
        public static List<Flight> flights = new List<Flight>();
        

        public static void ReadDatabase()
        {
            string[] lines = File.ReadAllLines("AviationData.txt");
            foreach (var item in lines)
            {
                string[] delimiters = new[] {" | "};
                var p = item.Split(delimiters, StringSplitOptions.None);
                //var p = item.Split(new string[] { " | " }, StringSplitOptions.None);
                //var p = item.Split('|');
                Flight f = new Flight(p[0], p[1], p[2], p[3], p[4], p[5], p[6], p[7], p[8], p[9], p[10], p[11], p[12], p[13], p[14], p[15],
                                      p[16], p[17], p[18], p[19], p[20], p[21], p[22], p[23], p[24], p[25], p[26],p[27], p[28],p[29],p[30]);


                flights.Add(f);
            }

        }

     }
}
