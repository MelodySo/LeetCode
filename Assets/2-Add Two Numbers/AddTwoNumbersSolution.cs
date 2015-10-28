namespace AddTwoNumbers{
	/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
	public class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
	public class Solution {
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
			ListNode head=null, prev=null;
			int carry = 0;
			while (l1!=null||l2!=null) {
				int v1 = l1 != null ? l1.val : 0;
				int v2 = l2 != null ? l2.val : 0;
				int tmp = v1 + v2 + carry;
				carry = tmp / 10;
				int val = tmp % 10;
				ListNode cur = new ListNode (val);
				if (head == null)
					head = cur;
				if (prev != null)
					prev.next = cur;
				prev = cur;
				if (l1 != null)
					l1 = l1.next;
				if (l2 != null)
					l2 = l2.next;
			}
			if (carry > 0) {
				ListNode l = new ListNode(carry);
				prev.next = l;
				
			}
			return head;
		}
	}
}