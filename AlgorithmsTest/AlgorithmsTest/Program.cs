using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string input = sr.ReadLine().ToLower();
            Dictionary<string, int> list = new Dictionary<string, int>();
            Int64 result = 0;
            foreach (char c in input)
            {
                if (list.ContainsKey(c.ToString()))
                {
                    list[c.ToString()] = list[c.ToString()] + 1;
                }
                else
                {
                    list.Add(c.ToString(), 1);
                }
            }
            Dictionary<string, int> dic1desc = list.OrderByDescending(p => p.Value).ToDictionary(o => o.Key, p => p.Value);
            int i = 26;
            foreach(int value in dic1desc.Values)
            {
                result += i * value;
                i--;
            }
             sw.WriteLine(result);
             
            sw.Flush();
            sr.Close();
            sw.Close();
            


        }
    }
}
