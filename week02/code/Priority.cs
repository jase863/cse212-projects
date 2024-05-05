public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following values: 1, 19, 3, 5, 19, 6, 8, 4
        // Expected Result: "The item with the highest priority is e." should be displayed.
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 19);
        priorityQueue.Enqueue("c", 3);
        priorityQueue.Enqueue("d", 5);
        priorityQueue.Enqueue("e", 19);
        priorityQueue.Enqueue("f", 6);
        priorityQueue.Enqueue("g", 8);
        priorityQueue.Enqueue("h", 4);

        Console.WriteLine(priorityQueue);
        Console.WriteLine();
        Console.WriteLine($"The item with the highest priority is {priorityQueue.Dequeue()}.");
        
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Attempt to use the Dequeue() method from an empty queue.
        // Expected Result: "The queue is empty." should be displayed.

        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        priorityQueue = new PriorityQueue(); 

        Console.WriteLine();

        priorityQueue.Dequeue();
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}