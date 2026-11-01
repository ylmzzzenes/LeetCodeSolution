namespace LeetCodeSolution.LeetCode75.Linked_List
{
    public class _328
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode? odd = head;
            ListNode? even = head.next;
            ListNode? evenHead = even;

            if (head == null || head.next == null)
            {
                return head;
            }

            while (even != null && even.next != null)
            {
                odd.next = odd.next.next;
                odd = odd.next;

                even.next = even.next.next;
                even = even.next;
            }
            odd.next = evenHead;

            return head;
        }
    }
}
