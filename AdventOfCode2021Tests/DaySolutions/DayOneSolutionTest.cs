using NUnit.Framework;
using AdventOfCode2021.DaySolutions;
using System.Collections.Generic;

namespace AdventOfCode2021Tests.DaySolutions
{
    public class DayOneSolutionTest
    {
        [Test]
        public void Test()
        {
            // arrange
            var sut = new DayOneSolution();
            var input = new List<int>()
            {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
            };

            // act
            var result = sut.GetNumberOfIncreases(input);

            // assert
            Assert.AreEqual(7, result);
        }
    }
}
