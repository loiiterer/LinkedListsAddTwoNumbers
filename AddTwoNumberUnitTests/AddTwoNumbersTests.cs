using AddTwoNumbersLib;

namespace AddTwoNumberUnitTests;

public class AddTwoNumbersTests
{
    [Fact]
    public void TwoLinkedListsWithTheSameNumberOfNodes()
    {
        ListNode l1Node3 = new(3);
        ListNode l1Node2 = new(4, l1Node3);
        ListNode l1Node1 = new(2, l1Node2);

        ListNode l2Node3 = new(4);
        ListNode l2Node2 = new(6, l2Node3);
        ListNode l2Node1 = new(5, l2Node2);

        ListNode actualLNode3 = new(8);
        ListNode actualLNode2 = new(0, actualLNode3);
        ListNode actualLNode1 = new(7, actualLNode2);

        string actualOutput = actualLNode1.PrintLinkedList();
        string expectedOutput = Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList();

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TwoLinkedListsWithZeroAsSingleNode()
    {
        ListNode l1Node1 = new(0);
        ListNode l2Node1 = new(0);
        ListNode actualLNode1 = new(0);

        string actualOutput = actualLNode1.PrintLinkedList();
        string expectedOutput = Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList();

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TwoLinkedListsWhenOneListIsLonger()
    {
        ListNode l1Node7 = new(9);
        ListNode l1Node6 = new(9, l1Node7);
        ListNode l1Node5 = new(9, l1Node6);
        ListNode l1Node4 = new(9, l1Node5);
        ListNode l1Node3 = new(9, l1Node4);
        ListNode l1Node2 = new(9, l1Node3);
        ListNode l1Node1 = new(9, l1Node2);

        ListNode l2Node4 = new(9);
        ListNode l2Node3 = new(9, l2Node4);
        ListNode l2Node2 = new(9, l2Node3);
        ListNode l2Node1 = new(9, l2Node2);

        ListNode actualLNode8 = new(1);
        ListNode actualLNode7 = new(0, actualLNode8);
        ListNode actualLNode6 = new(0, actualLNode7);
        ListNode actualLNode5 = new(0, actualLNode6);
        ListNode actualLNode4 = new(9, actualLNode5);
        ListNode actualLNode3 = new(9, actualLNode4);
        ListNode actualLNode2 = new(9, actualLNode3);
        ListNode actualLNode1 = new(8, actualLNode2);

        string actualOutput = actualLNode1.PrintLinkedList();
        string expectedOutput = Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList();

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TwoLinkedListsWhenOneListIsNull()
    {
        ListNode l1Node1 = null;

        ListNode l2Node2 = new(1);
        ListNode l2Node1 = new(0, l2Node2);

        ListNode actualLNode2 = new(1);
        ListNode actualLNode1 = new(0, actualLNode2);

        string actualOutput = actualLNode1.PrintLinkedList();
        string expectedOutput = Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList();

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TwoLinkedListsExtraCarry()
    {
        ListNode l1Node2 = new(9);
        ListNode l1Node1 = new(9, l1Node2);

        ListNode l2Node1 = new(1);

        ListNode actualLNode3 = new(1);
        ListNode actualLNode2 = new(0, actualLNode3);
        ListNode actualLNode1 = new(0, actualLNode2);

        string actualOutput = actualLNode1.PrintLinkedList();
        string expectedOutput = Solution.AddTwoNumbers(l1: l1Node1, l2: l2Node1).PrintLinkedList();

        Assert.Equal(expectedOutput, actualOutput);
    }
}