/*
You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists into one sorted list.
The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list.
*/

public class SolutionMergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Initialize a dummyNode
        ListNode dummyNode = new ListNode();
        // Pointer to the current node in the merged list
        ListNode currentNode = dummyNode;

        // Iterate while both list1 and list2 are not null
        while(list1 != null && list2 != null)
        {
            // If list1 is smaller than list2,
            if(list1.val < list2.val)
            {
                // update the currentNode to point to list1 and move list1 to the next node
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                // Update the currentNode to point to list2 and move list2 to the next node
                currentNode.next = list2;
                list2 = list2.next;
            }

            // Move the currentNode to the next node
            currentNode = currentNode.next;
        }

        // If list1 is not null, attach the remaining nodes to the currentNode
        if(list1 != null)
        {
            currentNode.next = list1;
        }
        // If list2 is not null, attach the remaining nodes to the currentNode
        if(list2 != null)
        {
            currentNode.next = list2;
        }

        // Return the head of the merged list (the next node of the dummyNode)
        return dummyNode.next;
    }
}