using CustomCollection;
using NUnit.Framework;
using System;

namespace CustomCollectionTests
{
    public class ExtendesIntergerArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanStoreIntegers()
        {
            var array = new ExtendedIntegerArray(1);
            Assert.DoesNotThrow(() => array[0] = 1);
        }
        
        [Test]
        public void ThrowsOnZeroLenght()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new ExtendedIntegerArray(0));
        }

        [Test]
        public void ShouldHavePositionForElements()
        {
            var array = new ExtendedIntegerArray(10);
            array[8] = 256;
            Assert.AreEqual(256, array[8]);
        }

        [Test]
        public void ShouldBeZeroIndexed()
        {
            var array = new ExtendedIntegerArray(10);
            array[0] = 1;
            Assert.AreEqual(1, array[0]);
        }

        [Test]
        public void ShouldHaveLastPositionAsLenghtMinusOne()
        {
            var array = new ExtendedIntegerArray(10);
            array[array.Length - 1] = 10;
            Assert.AreEqual(10, array[array.Length - 1]);
        }

        [Test]
        public void ShouldthrowWhenAccesingPostionEqualToLenght()
        {
            var array = new ExtendedIntegerArray(10);
            Assert.Throws<IndexOutOfRangeException>(() => array[array.Length] = 11);
        }

        [Test]
        public void CanCalculateSumBetweenTwoPositions()
        {
            var array = new ExtendedIntegerArray(100);

            for(int i = 0; i < 100; i++)
            {
                array[i] = i+1;
            }

            Assert.AreEqual(1010, array.SumOf(39, 59));
        }
    }
}