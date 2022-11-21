using Lab7;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StackTest1()
        {
            Stack<int> stack = new Stack<int>();
            var stack2 = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Recursion.Reverse(stack, stack2);

            var expected = new Stack<int>();
            for (int i = 1; i <= 3; i++)
            {
                expected.Push(i);
            }

            CollectionAssert.AreEquivalent(expected, stack2);
        }

        [TestMethod]
        public void BinaryTest1() //Tests an odd positive int
        {
            string val = Recursion.ToBinary(13);
            string expected = "1101";
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void BinaryTest2() //Tests an even positive int 
        {
            string val = Recursion.ToBinary(12);
            string expected = "1100";
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void BinaryTest3() //Tests the number 1 
        {
            string val = Recursion.ToBinary(1);
            string expected = "1";
            Assert.AreEqual(expected, val);
        }

        
    }
}