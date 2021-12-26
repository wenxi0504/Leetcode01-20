using System;

namespace _19._Remove_Nth_Node_From_End_of_List
{ /*19. Given the head of a linked list, 
   * remove the nth node from the end of the list and return its head.
   * 
   */
    public class ListNode
    {
        public int val;
        public ListNode next;
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v5;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int v1, int v2, int v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }
    }
        class Program
    {     

        static void Main(string[] args)
        {   
            //Input: head = [1, 2, 3, 4, 5], n = 2
            //Output:[1,2,3,5]

            ListNode test = new ListNode( 1, 2, 3, 4, 5 );


            Console.WriteLine();
        }
    }

    public class Solution
    {
        public  static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // set a dummy before the head of ListNode
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            // set a slow and fast, the distance bewteen fast and slow is int n
            ListNode fast = dummy;
            ListNode slow = dummy;

            // run fast to get the n
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }
            //iterate the fast and slow,until fast.next is null
            while (fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            //then hook the slow right after the goal node
            slow.next = slow.next.next;

            return dummy.next;





        }
    }
}
