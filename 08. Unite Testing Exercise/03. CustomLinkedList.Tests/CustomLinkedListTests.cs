namespace CustomLinkedList.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class CustomLinkedListTests
    {
        private DynamicList<int> linkedList;

        [SetUp]
        public void SetUp()
        {
            this.linkedList = new DynamicList<int>();
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Add_ShouldAddElementsCorrectly(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var expectedResult = new List<int>() { 1, 2, 3 };


            for (int i = 0; i < this.linkedList.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], this.linkedList[i]);
            }
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Count_ShouldReturnCorrectCountOfElements(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var expectedResult = 3;
            var actualResult = this.linkedList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void GetElement_FromValidIndex_ShouldReturnCorrectValue(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var expectedValue = 3;
            var actualValue = this.linkedList[this.linkedList.Count - 1];

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void GetElement_FromInvalidIndex_ShouldReturnArgumentOutOfRangeException(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            int invalidIndex = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                int element = this.linkedList[invalidIndex];
            }, $"Invalid index: {invalidIndex}");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void SetElement_FromValidIndex_ShouldSetnCorrectValue(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var expectedValue = 4;
            this.linkedList[this.linkedList.Count - 1] = expectedValue;
            var actualValue = this.linkedList[this.linkedList.Count - 1];

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void SetElement_FromInvalidIndex_ShouldReturnArgumentOutOfRangeException(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var invalidIndex = this.linkedList.Count;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.linkedList[invalidIndex] = 4;
            }, $"Invalid index: {invalidIndex}");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveAt_ValidIndex_ShouldRemoveElementCorrectly(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var index = 2;
            var expectedResult = new List<int>() { 1, 2 };
            this.linkedList.RemoveAt(index);

            for (int i = 0; i < this.linkedList.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], this.linkedList[i]);
            }
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveAt_InvalidIndex_ShouldReturnArgumentOutOfRangeException(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var index = 3;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.linkedList.RemoveAt(index);
            }, $"Invalid index: {index}");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveAt_ValidIndex_ShouldDecreaseTheCountOfTheElements(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var expectedCount = 2;
            this.linkedList.RemoveAt(1);
            var actualCount = this.linkedList.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveAt_ValidIndex_ShouldRemoveTheCorrectElement(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var index = 0;
            var expectedResult = 1;
            var actualResult = this.linkedList.RemoveAt(index);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Remove_ValidItem_ShouldReturnCorrecntIndex(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 2;
            var expectedIndex = 1;
            var actualIndex = this.linkedList.Remove(item);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Remove_InvalidItem_ShouldReturnCorrecntIndex(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 4;
            var expectedIndex = -1;
            var actualIndex = this.linkedList.Remove(item);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Remove_ValidItem_ShouldDecreaseCountOfTheElements(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 3;
            var expectedCount = 2;
            var actualCount = this.linkedList.Remove(item);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void IndexOf_ValidItem_ShouldReturnItsCorrectIndex(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 2;
            var expectedIndex = 1;
            var actualIndex = this.linkedList.IndexOf(item);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void IndexOf_InvalidItem_ShouldReturnItsCorrectIndex(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 4;
            var expectedIndex = -1;
            var actualIndex = this.linkedList.IndexOf(item);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Contains_ExistingElement_ShouldReturnTrue(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 2;
            var expectedResult = true;
            var actualResult = this.linkedList.Contains(item);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void Contains_NonExistingElement_ShouldReturnFalse(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.linkedList.Add(elements[i]);
            }

            var item = 4;
            var expectedResult = false;
            var actualResult = this.linkedList.Contains(item);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
