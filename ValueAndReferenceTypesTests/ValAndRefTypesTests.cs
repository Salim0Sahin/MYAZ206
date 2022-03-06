using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void RefTypeTest()
        {
            //Arrange
            var p1 = new ReferenceType()
            {
                X = 1,
                Y = 2,
            };

            //Act
            var p2 = p1;
            p2.X = 3;

            //Assert
            Assert.Equal(p1.X, p2.X);
        }

        [Fact]
        public void ValTypeTest()
        {
            //Arrange
            var p1 = new ValueType()
            {
                X = 1,
                Y = 2,
            };

            //Act
            var p2 = p1;
            p2.X = 3;

            //Assert
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void RecordTypeTest()
        {
            //Arrange
            var p1 = new RecordType(3, 5);
            //  p1.X = 4;   bunu diyemeyiz çünkü deðeri sadece tanýmlanýrken girilir. hata verir burda

            //Act
            var p2 = new RecordType(30, 50);

            //Assert
            Assert.NotEqual(p1, p2);

        }

        [Fact]
        public void SwapByVal()
        {
            //Arrange
            int a = 23, b = 55;
            var valType = new ValueType();

            //Act
            valType.Swap(a, b);

            //Assert
            Assert.Equal(55, b);
            Assert.Equal(23, a);
        }

        [Fact]
        public void SwapByRef()
        {
            //Arrange
            int a = 23, b = 55;
            var valType = new ReferenceType();

            //Act
            valType.Swap(ref a, ref b);

            //Assert
            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }

        [Fact]
        public void CheckOutKeyword()
        {
            //Arrange
            var refType = new ReferenceType();
            int b = 5;

            //Act
            refType.ChechOut(out b);

            //Assert
            Assert.Equal(10, b);
        }


    }
}