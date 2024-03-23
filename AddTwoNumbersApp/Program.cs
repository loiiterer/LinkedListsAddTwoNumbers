using AddTwoNumbersLib; // To use ListNode and Solution

ListNode l1Node3 = new(3);
ListNode l1Node2 = new(4, l1Node3);
ListNode l1Node1 = new(2, l1Node2);

ListNode l2Node3 = new(4);
ListNode l2Node2 = new(6, l2Node3);
ListNode l2Node1 = new(5, l2Node2);

// ListNode l3Node1 = null;

try
{
    // l3Node1.PrintLinkedList();

    Write(string.Format("[{0}] + [{1}] = [{2}]",
    arg0: l1Node1.PrintLinkedList(), arg1: l2Node1.PrintLinkedList(),
    arg2: Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList()));

    // Create magic with linked lists here
}
catch (NullReferenceException) 
{
    WriteLine("linked list is null");
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}