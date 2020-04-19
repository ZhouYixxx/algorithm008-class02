/*
21. 合并两个有序链表 
将两个升序链表合并为一个新的升序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：
输入：1->2->4,  1->3->4
输出：1->1->2->3->4->4
 */

using System.Collections;

namespace CodePractice.LeetCode.Array
{
    //合并两个有序链表，时间复杂度为O(n)，空间复杂度O(1)
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        //特殊情况处理
        if(l1 == null)
        {
            return l2;
        }
        if(l2 == null)
        {
            return l1;
        }
        //设置一个头结点
        ListNode preHead = new ListNode(0);
        ListNode prevNode = preHead;
        while (l1 != null && l2 != null)
        {
            //l1的值更小，将prevNode的next设置为l1, l1则指向下一个节点
            if (l1.val <= l2.val)
            {
                prevNode.next = l1;
                l1 = l1.next;
            }
            //l2的值更小，将prevNode的next设置为l2, l2则指向下一个节点
            else
            {
                prevNode.next = l2;
                l2 = l2.next;
            }
            prevNode = prevNode.next;
        }
        //最终l1和l2必有一个为空，将将prevNode的next指向余下的另一个节点即可
        prevNode.next = l1 == null ? l2:l1;
        return preHead.next;
    }
}
