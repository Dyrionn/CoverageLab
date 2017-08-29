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
            Console.WriteLine("First call : " + dummy.DummyFunctionOne("blah"));
            Console.WriteLine("Second call : " + dummy.DummyFunctionTwo());
            Console.WriteLine("First call : " + dummy.DummyFunctionThree(4));
            Console.ReadKey();
        }
    }
}
