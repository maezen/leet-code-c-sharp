// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 14.04.2019 15:58
// </cleanup>
// -----------------------------------------------------------------------

using Xunit;

namespace LeetCodeCSharp.Test
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void TestAddTwoNumbers1()
        {
            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7 -> 0 -> 8
            // Explanation: 342 + 465 = 807

            var l1c = new ListNode(3);
            var l1b = new ListNode(4) {next = l1c};
            var l1a = new ListNode(2) {next = l1b};

            var l2c = new ListNode(4);
            var l2b = new ListNode(6) {next = l2c};
            var l2a = new ListNode(5) {next = l2b};

            var resultA = AddTwoNumbersSolution.AddTwoNumbers(l1a, l2a);
            var resultB = resultA.next;
            var resultC = resultA.next.next;

            var resultString = string.Concat(resultC.val, resultB.val, resultA.val);
            Assert.Equal("807", resultString);
        }
        
        [Fact]
        public void TestAddTwoNumbers2()
        {
            var l1b = new ListNode(8);
            var l1a = new ListNode(1) {next = l1b};

            var l2a = new ListNode(0);

            var resultA = AddTwoNumbersSolution.AddTwoNumbers(l1a, l2a);
            var resultB = resultA.next;

            var resultString = string.Concat(resultB.val, resultA.val);
            Assert.Equal("81", resultString);
        }
        
        [Fact]
        public void TestAddTwoNumbers3()
        {
            var l1a = new ListNode(0);
            
            var l2b = new ListNode(8);
            var l2a = new ListNode(1) {next = l2b};


            var resultA = AddTwoNumbersSolution.AddTwoNumbers(l1a, l2a);
            var resultB = resultA.next;

            var resultString = string.Concat(resultB.val, resultA.val);
            Assert.Equal("81", resultString);
        }
        
        [Fact]
        public void TestAddTwoNumbers4()
        {
            var l1a = new ListNode(9);
            
            var l2b = new ListNode(9);
            var l2a = new ListNode(5) {next = l2b};


            var resultA = AddTwoNumbersSolution.AddTwoNumbers(l1a, l2a);
            var resultB = resultA.next;
            var resultC = resultB.next;

            var resultString = string.Concat(resultC.val, resultB.val, resultA.val);
            Assert.Equal("104", resultString);
        }
        
    }
}
