namespace AddTwoNumbersLib;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode next = next;

    public string PrintLinkedList()
    {
        string sequence = string.Empty;
        if (next is not null) 
        {
            sequence += $"{val},";
            sequence += next.PrintLinkedList();
        }
        else
        {
            sequence += $"{val}";
        }
        return sequence;
    }
}
