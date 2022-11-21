using Lab7;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StackTest1() //Checking if stack is reversed. Includes negative values and 0.
        {
            var stack = new Stack<int>();
            var stack2 = new Stack<int>();
            stack.Push(-3);
            stack.Push(2);
            stack.Push(0);
            var expected = new Stack<int>();
            expected.Push(0);
            expected.Push(2);
            expected.Push(-3);

            Recursion.Reverse(stack, stack2);            
            CollectionAssert.AreEquivalent(expected, stack2);
        }

        [TestMethod]
        public void StackTest2() //Making sure stack is unmodified after method returns
        {
            var stack = new Stack<int>();
            var stack2 = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            var expected = new Stack<int>();
            expected.Push(3);
            expected.Push(2);
            expected.Push(1);
            
            Recursion.Reverse(stack, stack2);
            CollectionAssert.AreEquivalent(expected, stack);
        }

        [TestMethod]
        public void SubsetTest1() //Tests a subset with duplicate values 
        {
            var sub = new List<int>();
            sub.Add(1);
            sub.Add(1);
            var set = new List<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);

            var expected = true;
            var output = Recursion.IsASubset(sub, set);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void SubsetTest2() //Tests a subset with unique values (including neg number)
        {
            var sub = new List<int>();
            sub.Add(-1);
            sub.Add(int.MaxValue);
            var set = new List<int>();
            set.Add(-1);
            set.Add(2);
            set.Add(int.MaxValue);

            var expected = true;
            var output = Recursion.IsASubset(sub, set);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void SubsetTest3() //Tests an empty subset
        {
            var sub = new List<int>();
            var set = new List<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            var expected = true;
            var output = Recursion.IsASubset(sub, set);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void SubsetTest4() //Tests a subset with some true and some false values 
        {
            var sub = new List<int>();
            sub.Add(1);
            sub.Add(7);
            var set = new List<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            var expected = false;
            var output = Recursion.IsASubset(sub, set);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void SubsetTest5() //Tests a subset with all false values 
        {
            var sub = new List<int>();
            sub.Add(int.MaxValue);
            sub.Add(7);
            var set = new List<int>();
            var expected = false;
            var output = Recursion.IsASubset(sub, set);

            Assert.AreEqual(expected, output);
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