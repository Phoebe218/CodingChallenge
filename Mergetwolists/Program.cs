using System;

// Define the ListNode class
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

// Define the Solution class with the MergeTwoLists method
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Create a dummy node to simplify the merge process
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        // Traverse both lists
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        // Append the remaining nodes
        if (list1 != null)
        {
            tail.next = list1;
        }
        else if (list2 != null)
        {
            tail.next = list2;
        }

        // Return the merged list, which starts from the node after the dummy
        return dummy.next;
    }
}

// Main class to run the example
class Program
{
    static void Main()
    {
        // Create example lists
        ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

        // Merge the lists
        Solution solution = new Solution();
        ListNode mergedList = solution.MergeTwoLists(list1, list2);

        // Print the merged list
        PrintList(mergedList);
    }

    // Helper method to print the linked list
    static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

