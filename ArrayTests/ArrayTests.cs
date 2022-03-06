using DataStructures.Array;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void CheckArrayConstructor(int defaultSize)
        {
            //Arrange | Act
            var arr = new Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, arr.Length);
        }

        [Fact]
        public void CheckArrayConstructorWithParams()
        {
            //Arrange | Act
            var array = new DataStructures.Array.Array(1, 2, 3, 4, 5);

            //Assert
            Assert.Equal(5,array.Length);
        }

        [Fact]
        public void GetAndSetValuesInArray()
        {
            //Arrange
            var array = new DataStructures.Array.Array();

            //Act
            array.SetValue(21, 0);
            array.SetValue(43, 1);

            //Assert
            Assert.Equal(21, array.GetValue(0));
            Assert.Equal(43, array.GetValue(1));
            Assert.Null(array.GetValue(9));

        }

        [Fact]
        public void ArrayCloneTest()
        {
            //Arrange
            var array = new DataStructures.Array.Array(3, 5, 7);

            //Act
            var clonedArray = array.Clone() as DataStructures.Array.Array;

            //Assert
            Assert.NotNull(clonedArray);
            Assert.Equal(array.Length, clonedArray.Length);
            Assert.NotEqual(array.GetHashCode(), clonedArray.GetHashCode());
        }

        [Fact]
        public void ArrayGetEnumeratorTest()
        {
            //Arrange
            var array = new DataStructures.Array.Array(10,20,30);

            //Act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            //Assert
            Assert.Equal("102030", s);
        }

    }
}