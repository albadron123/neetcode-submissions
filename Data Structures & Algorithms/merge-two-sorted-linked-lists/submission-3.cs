/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        ListNode head;
        ListNode current;
        if(list1.val < list2.val)
        {
            head = list1;
            list1 = list1.next;
        }
        else
        {
            head = list2;
            list2 = list2.next;
        }
        current = head;
        while(list1 != null || list2 != null)
        {
            if(list2 == null || list1 != null && list1.val < list2.val)
            {
                current.next = list1;
                current = current.next;
                list1 = list1.next;
            }
            else if (list1 == null || list2 != null && list1.val >= list2.val)
            {
                current.next = list2;
                current = current.next;
                list2 = list2.next;
            }   
        }
        return head;
    }
}