using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToysEnumLibrary;

namespace ToysEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildrenToys toys = new ChildrenToys(1);

            toys.ToysCalculation();
        }
    }
}
