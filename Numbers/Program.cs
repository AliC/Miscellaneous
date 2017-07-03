using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string numbers = "123456789";
            List<string> groups = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    groups.Add($"{string.Join("", numbers.Where((n, idx) => idx > j - 1 && idx <= i + j)) } {string.Join("", numbers.Where((n, idx) => idx > i + j))}");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, groups));

        }
    }
}
