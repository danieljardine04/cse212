using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

     PriorityItem naruto = new PriorityItem("I will be the Hokago", 5);
     PriorityItem jiriya = new PriorityItem("I am the Toadsage, JIRIYAAAAAA!", 6);
     PriorityItem sakura = new PriorityItem("Stupid Naruto!", 1);
     PriorityItem tsunade = new PriorityItem("All I will need to beat you is this finger.", 4);
     PriorityItem sauske = new PriorityItem("I will kill a certain someone, and restore my clan", 2);
     PriorityItem oruchimaru = new PriorityItem("I will have Sauske", 2);
    [TestMethod]
    // Scenario: Adding Naruto (5), Jiriya(6), Sakura(1), Tsunade(4) and Sauske(2), Oruchimaru(2) to the queue
    // Expected Result: Expected order they should appear Naruto, Jiriya, Sakura, Tsunade, Sauske, Oruchimaru, 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(naruto.Value, 2);
        priorityQueue.Enqueue(jiriya.Value, 2);
        priorityQueue.Enqueue(sakura.Value, 2);
        priorityQueue.Enqueue(tsunade.Value, 2);
        priorityQueue.Enqueue(sauske.Value, 2);
        priorityQueue.Enqueue(oruchimaru.Value, 2);

        PriorityItem[] expectedResult = [naruto, jiriya, sakura, tsunade, sauske, oruchimaru];

        for(int i = 0; i < priorityQueue.Length; i++){
            var person = priorityQueue.Dequeue();
             Assert.IsTrue(person == expectedResult[i].Value, "The Priority items should match");
        }

        

    }

    [TestMethod]
    // Scenario: The person leaving the Queue should be the person with the highest priority and 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(naruto.Value, naruto.Priority);
        priorityQueue.Enqueue(jiriya.Value, jiriya.Priority);
        priorityQueue.Enqueue(sakura.Value, sakura.Priority);
        priorityQueue.Enqueue(tsunade.Value, tsunade.Priority);
        priorityQueue.Enqueue(sauske.Value, sauske.Priority);
        priorityQueue.Enqueue(oruchimaru.Value, oruchimaru.Priority);

         PriorityItem[] expectedResult = [jiriya, naruto, tsunade, sauske, oruchimaru, sakura];

         for(int i = 0; i < priorityQueue.Length; i++){
            var person = priorityQueue.Dequeue();
            Assert.IsTrue(person == expectedResult[i].Value, "The Priority items should match");
         }
        ;
    }

    // Add more test cases as needed below.
}