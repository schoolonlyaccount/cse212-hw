using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue with the following elements and their priority level: item_A (1), item_B (3), item_C (2), item_D (1), item_E (3)
    // Dequeuing an element should be removed by highest priority from left to right
    // Expected Result: item_B, item_E, item_C, item_A, item_D
    // Defect(s) Found: The for loop in the Dequeue method started at index 1 instead of 0, and checked if less than _queue.Count - 1 instead of _queue.Count,
    // causing elements to be skipped.
    // In the for loop, the priority returned was from right to left due to the greater than or equal to check. I Changed it to just be greater than.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item_A", 1);
        priorityQueue.Enqueue("item_B", 3);
        priorityQueue.Enqueue("item_C", 2);
        priorityQueue.Enqueue("item_D", 1);
        priorityQueue.Enqueue("item_E", 3);

        string[] expectedResult = ["item_B", "item_E", "item_C", "item_A", "item_D"];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a priority queue with the following elements and their priority level: Addition (0), Multiplication (1), Exponents (2), Division (1), Parenthesis (3), Substraction (0)
    // Dequeuing an element should be removed by highest priority from left to right
    // Expected Result: Parenthesis, Exponents, Multiplication, Division, Addition, Subtraction
    // Defect(s) Found: The for loop in the Dequeue method started at index 1 instead of 0, and checked if less than _queue.Count - 1 instead of _queue.Count,
    // causing elements to be skipped.
    // In the for loop, the priority returned was from right to left due to the greater than or equal to check. I Changed it to just be greater than.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Addition", 0);
        priorityQueue.Enqueue("Multiplication", 1);
        priorityQueue.Enqueue("Exponents", 2);
        priorityQueue.Enqueue("Division", 1);
        priorityQueue.Enqueue("Parenthesis", 3);
        priorityQueue.Enqueue("Subtraction", 0);

        string[] expectedResult = ["Parenthesis", "Exponents", "Multiplication", "Division", "Addition", "Subtraction"];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Attempts a dequeue on an empty priority queue
    // Expected Result: InvalidOperationException with message "The queue is empty"
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}