using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }




    // Add more test cases as needed below.

    // cheking if the priority queue is working as expected with multiple items and priorities.
    [TestMethod]
    public void TestPriorityQueue_3()
    {
        var e = new PriorityQueue();
        e.Enqueue("A", 1);
        e.Enqueue("B", 2);
        e.Enqueue("C", 3);

        if (e.Dequeue() != "C")
        {
            Assert.Fail("Expected C to be dequeued first.");
        }

        if (e.Dequeue() != "B")
        {
            Assert.Fail("Expected B to be dequeued second.");
        }

        if (e.Dequeue() != "A")
        {
            Assert.Fail("Expected A to be dequeued third.");
        }
        
    }

    // checking if the priority queue is working as expected with multiple items and priorities, including duplicate priorities.
    [TestMethod]
    public void TestPriorityQueue_4()
    {
        var e = new PriorityQueue();
        e.Enqueue("A", 1);
        e.Enqueue("B", 2);
        e.Enqueue("C", 3);
        e.Enqueue("D", 2);

        if (e.Dequeue() != "C")
        {
            Assert.Fail("Expected C to be dequeued first.");
        }

        if (e.Dequeue() != "D")
        {
            Assert.Fail("Expected D to be dequeued second.");
        }

        if (e.Dequeue() != "B")
        {
            Assert.Fail("Expected B to be dequeued third.");
        }

        if (e.Dequeue() != "A")
        {
            Assert.Fail("Expected A to be dequeued fourth.");
        }
    }
}