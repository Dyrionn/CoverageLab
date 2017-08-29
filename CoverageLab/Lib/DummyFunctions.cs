using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverageLab.Lib
{
    public class DummyFunctions
    {

        public bool dummyFunctionOne(string id)
        {
            return !String.IsNullOrEmpty(id); ;
        }

        public bool dummyFunctionTwo()
        {
            return true ;
        }

        public bool dummyFunctionThree(int id)
        {
            return (id % 2) == 0;
        }

    }
}
