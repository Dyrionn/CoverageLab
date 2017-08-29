using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoverageLab.Lib;
using Xunit;

namespace CoverageLab.Test
{
    public class DummyFunctionsTest
    {
        [Fact]
        public void dummyFunctionOne_Failure()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.dummyFunctionOne(null);

            Assert.False(result);

        }

        [Fact]
        public void dummyFunctionOne_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.dummyFunctionOne("blah");

            Assert.True(result);

        }

        [Fact]
        public void dummyFunctionTwo_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.dummyFunctionTwo();

            Assert.True(result);

        }

        [Fact]
        public void dummyFunctionThree_Failure()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.dummyFunctionThree(9);

            Assert.False(result);
        }

        [Fact]
        public void dummyFunctionThree_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.dummyFunctionThree(4);

            Assert.True(result);

        }


    }
}
