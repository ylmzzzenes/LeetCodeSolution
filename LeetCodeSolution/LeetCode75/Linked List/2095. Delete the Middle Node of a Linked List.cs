namespace LeetCodeSolution.LeetCode75.Linked_List
{
    public class _2095
    {
        public ListNode? DeleteMiddle(ListNode head)
        {
            if(head.next == null)
                return null;
            ListNode? slow = head;
            ListNode? fast = head;
            ListNode? prev = null;

            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = slow.next;

            return head;
        }
    }
}
