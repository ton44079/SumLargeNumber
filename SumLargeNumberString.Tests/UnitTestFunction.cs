using System;
using SumLargeNumberString.Helpers;
using Xunit;

namespace SumLargeNumberString.Tests
{
    public class UnitTestFunction
    {
        [Theory]
        [InlineData("100", "100", "200")]
        [InlineData("9999999", "34567", "10034566")]
        [InlineData("10000000000000000000", "10000000000000000000", "20000000000000000000")]
        [InlineData("83943849878979327492374", "637988609750928402384", "84581838488730255894758")]
        public void Test1(string number1, string number2, string expected)
        {
            //Given
            //When
            var result = FuncHelper.Sum(number1, number2);

            //Then
            Assert.Equal(expected, result);
        }
    }
}
