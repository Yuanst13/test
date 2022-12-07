namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            ListNode a= new(2,new ListNode(4,new ListNode(3)));
            ListNode b= new(5, new ListNode(6, new ListNode(4)));
            ListNode current=Solution.AddTwoNumbers(a,b);
            while (current != null) { Console.WriteLine(current.val);current= current.next;}
        }
    }
    public class Solution
    {
        //实现两个链表的相加
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new(0);
            ListNode current = head;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                current.next = new(sum % 10);
                current = current.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry > 0)
            {
                current.next = new(carry);
            }
            return head.next;
        }   

        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int current = 0;
            int start = 0;
            int end = 0;
            int[] arr = new int[128];
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[s[i]] == 0)
                {
                    arr[s[i]] = i + 1;
                    current++;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                        start = i - current;
                        end = i;
                    }
                    i = arr[s[i]] - 1;
                    current = 0;
                    arr = new int[128];
                }
            }
            if (current > max)
            {
                max = current;
                start = s.Length - current;
                end = s.Length;
            }
            return max;
            
        }
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
}