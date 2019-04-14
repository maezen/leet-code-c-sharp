// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 14.04.2019 21:29
// </cleanup>
// -----------------------------------------------------------------------

namespace LeetCodeCSharp
{
//Definition for singly-linked list.
    public class ListNode
    {
        #region Fields

        public ListNode next;

        public int val;

        #endregion

        #region  Constructors

        public ListNode(int x)
        {
            val = x;
        }

        #endregion
    }


    public class AddTwoNumbersSolution
    {
        #region Public Methods

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var currentL1 = l1;
            var currentL2 = l2;
            var dummyL3 = new ListNode(0);
            var currentL3 = dummyL3;

            var carry = 0;
            while (currentL1 != null || currentL2 != null)
            {
                var val1 = currentL1?.val ?? 0;
                var val2 = currentL2?.val ?? 0;
                var sum = val1 + val2 + carry;
                carry = sum / 10;
                sum = sum % 10;

                currentL3.next = new ListNode(sum);
                currentL3 = currentL3.next;

                currentL1 = currentL1?.next;
                currentL2 = currentL2?.next;
            }

            if (carry > 0) { currentL3.next = new ListNode(carry); }

            return dummyL3.next;
        }

        #endregion
    }
}
