using NUnit.Framework;
using AdventOfCode2021.DaySolutions;
using System.Collections.Generic;

namespace AdventOfCode2021Tests.DaySolutions
{
    public class DayOneSolutionTest
    {
        [Test]
        public void GetNumberOfIncreases_SmallMeasurementWindow()
        {
            // arrange
            var sut = new DayOneSolution();

            // act
            var result = sut.GetNumberOfIncreases(sampleInput, 1);

            // assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void GetNumberOfIncreases_WithMeasurementWindow() {
            // arrange
            var sut = new DayOneSolution();

            // act
            var result = sut.GetNumberOfIncreases(sampleInput, 3);

            // assert
            Assert.AreEqual(5, result);
        }

        static readonly List<int> sampleInput = new List<int>()
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
    }
}
