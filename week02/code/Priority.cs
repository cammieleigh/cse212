using System.Globalization;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with two names of different priority. See which one is dequeued.
        // Expected Result: Harry
        Console.WriteLine("Test 1");
        var numbers = new PriorityQueue();
        numbers.Enqueue("Harry", 1);
        numbers.Enqueue("Melanie", 2);
        numbers.Enqueue("Anne", 3);
        numbers.Enqueue("Jake", 5);
        numbers.Dequeue();
        numbers.Dequeue();
        
  
        // Defect(s) Found:  When finding highest priority, the code was using the number of the index instead of the number of priority

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with two names of the same value.
        // Expected Result: Harry
        Console.WriteLine("Test 2");
        numbers = new PriorityQueue();
        numbers.Enqueue("Sadie", 2);
        numbers.Enqueue("Harry", 2);
        numbers.Enqueue("Melanie", 2);
        numbers.Enqueue("Anne", 2);
        numbers.Dequeue();

        // Defect(s) Found: When finding highest priority, the if statement was for greater than or equal to 
        //highest priority, so if there were multiple of the same highest priority, the index would 
        //continue to be replaced.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        Console.WriteLine("Test 3");
        //See if an error will be thrown if there is no one in the queue
        numbers = new PriorityQueue();
        numbers.Dequeue();
    }
}