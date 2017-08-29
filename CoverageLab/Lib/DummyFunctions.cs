using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverageLab.Lib
{
    public class DummyFunctions
    {

        public bool DummyFunctionOne(string id)
        {
            return !String.IsNullOrEmpty(id); ;
        }

        public bool DummyFunctionTwo()
        {
            return true ;
        }

        public bool DummyFunctionThree(int id)
        {
            return (id % 2) == 0;
        }

    }
}
