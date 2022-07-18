using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    public class ReadOnlyExample
    {
        public readonly int num = 5;

    }
    public class StringTest
    {
       static void Main(string[] args)
       {
         ReadOnlyExample read = new ReadOnlyExample();
         Console.WriteLine(read.num);
       }

    }
}
