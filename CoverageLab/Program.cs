using CoverageLab.Lib;
using System;

namespace CoverageLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Dummy Functions:");

            var dummy = new DummyFunctions();
            Console.WriteLine("First call : " + dummy.dummyFunctionOne("blah"));
            Console.WriteLine("Second call : " + dummy.dummyFunctionTwo());
            Console.WriteLine("First call : " + dummy.dummyFunctionThree(4));
            Console.ReadKey();
        }
    }
}
