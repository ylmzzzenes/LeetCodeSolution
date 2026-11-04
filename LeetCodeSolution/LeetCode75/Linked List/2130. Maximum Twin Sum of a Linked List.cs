namespace LeetCodeSolution.LeetCode75.Linked_List
{
    public class _2130
    {
        public int PairSum(ListNode head)
        {
            ListNode? slow = head;
            ListNode? fast = head;
           

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode? prev = null;
            ListNode? current = slow;
            ListNode? next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            ListNode? firstHalf = head;
            ListNode? secondHalf = prev;
            int maxSum = 0;

            while (secondHalf != null)
            {
                maxSum = Math.Max(maxSum, firstHalf.val + secondHalf.val);
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return maxSum;
        }
    }
}
