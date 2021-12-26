using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode n = new ListNode();
            ListNode l1 = new ListNode(0);
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                int sum = 0;
                int addNum = 0;
                // ListNode result = new ListNode(0);
                ListNode headNode = new ListNode();//头节点
                ListNode lastnode = headNode;
                while (l1 != null || l2 != null)
                {
                    sum = addNum + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                    lastnode.next = new ListNode(sum % 10);//第一个赋值的节点
                    addNum = sum / 10;
                    l1 = l1 == null ? null : l1.next;
                    l2 = l2 == null ? null : l2.next;
                }
                return headNode;

            }
        }
    }
}
