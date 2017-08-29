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

            var result = testedClass.DummyFunctionOne(null);

            Assert.False(result);

        }

        [Fact]
        public void dummyFunctionOne_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.DummyFunctionOne("blah");

            Assert.True(result);

        }

        [Fact]
        public void dummyFunctionTwo_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.DummyFunctionTwo();

            Assert.True(result);

        }

        [Fact]
        public void dummyFunctionThree_Failure()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.DummyFunctionThree(9);

            Assert.False(result);
        }

        [Fact]
        public void dummyFunctionThree_Success()
        {
            var testedClass = new DummyFunctions();

            var result = testedClass.DummyFunctionThree(4);

            Assert.True(result);

        }


    }
}
