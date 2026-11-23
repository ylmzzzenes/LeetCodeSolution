namespace LeetCodeSolution.Random
{
    public class _2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode current = head;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = l1?.val ?? 0;
                int val2 = l2?.val ?? 0;
                int sum = (val1 + val2 + carry) % 10;
                carry = (val1 + val2 + carry) / 10;
                current.next = new ListNode(sum);
                current = current.next;
                l1 = l1?.next ;
                l2 = l2?.next;
            }

            return head.next;
        }
    }
}