using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
public void TestPriorityQueue_EmptyQueue()
{
    var e = new PriorityQueue();

    try
    {
        e.Dequeue();
        Assert.Fail("Expected an exception for empty queue.");
    }
    catch (InvalidOperationException ex)
    {
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}

[TestMethod]
public void TestPriorityQueue_HighestPriority()
{
    var e = new PriorityQueue();

    e.Enqueue("A", 1);
    e.Enqueue("B", 5);
    e.Enqueue("C", 3);

    if (e.Dequeue() != "B")
    {
        Assert.Fail("Expected B to be dequeued first.");
    }
}

[TestMethod]
public void TestPriorityQueue_FIFOWithSamePriority()
{
    var e = new PriorityQueue();

    e.Enqueue("A", 2);
    e.Enqueue("B", 2);
    e.Enqueue("C", 2);

    if (e.Dequeue() != "A")
    {
        Assert.Fail("Expected A to be dequeued first because of FIFO order.");
    }

    if (e.Dequeue() != "B")
    {
        Assert.Fail("Expected B to be dequeued second because of FIFO order.");
    }

    if (e.Dequeue() != "C")
    {
        Assert.Fail("Expected C to be dequeued third because of FIFO order.");
    }
}

[TestMethod]
public void TestPriorityQueue_MultipleDequeue()
{
    var e = new PriorityQueue();

    e.Enqueue("Low", 1);
    e.Enqueue("Medium", 5);
    e.Enqueue("High", 10);

    if (e.Dequeue() != "High")
    {
        Assert.Fail("Expected High first.");
    }

    if (e.Dequeue() != "Medium")
    {
        Assert.Fail("Expected Medium second.");
    }

    if (e.Dequeue() != "Low")
    {
        Assert.Fail("Expected Low third.");
    }
}

[TestMethod]
public void TestPriorityQueue_RemoveItemCorrectly()
{
    var e = new PriorityQueue();

    e.Enqueue("A", 1);
    e.Enqueue("B", 3);

    e.Dequeue();

    if (e.Dequeue() != "A")
    {
        Assert.Fail("Expected A after removing B.");
    }
}
}