using ClassLibrary1;
using System;
using Xunit;

namespace TDDTester
{
    public class CrushKillDestroy
    {
        [Fact]
        public void TwoStringsTest()
        {
            //arrange
            Class1 obj = new Class1();
            string[] strings = {"Hello", "World"};

            //act
            int length = obj.StringLength(strings);

            //assert
            Assert.Equal(5 + 5, length);
        }

        [Fact]
        public void EmptyArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = { };

            int lenght = obj.StringLength(strings);

            Assert.Equal(0, lenght);
        }

        [Fact]
        public void NullArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = null;

            int length = obj.StringLength(strings);

            Assert.Equal(0, length);
        }

        [Fact]
        public void CombineTest()
        {
            Class1 obj = new Class1();
            string[] strings = {"Hello", null, "World"};

            int length = obj.StringLength(strings);

            Assert.Equal(5 + 5, length);
        }
    }
}
