using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please select a data structure to use:");
            Console.WriteLine("1. Queue");
            Console.WriteLine("2. PriorityQueue");
            Console.WriteLine("3. Stack");
            Console.WriteLine("4. LinkedList");
            Console.WriteLine("5. Dictionary");
            Console.WriteLine("6. SortedList");
            Console.WriteLine("7. HashSet");
            Console.WriteLine("8. List");
            Console.WriteLine("9. Exit");

            string input = Console.ReadLine();
            int selection;

            if (!int.TryParse(input, out selection))
            {
                Console.WriteLine("Invalid selection. Please enter a number between 1 and 9.");
                continue;
            }

            switch (selection)
            {
                case 1:
                    QueueDemo();
                    break;

                case 2:
                    PriorityQueueDemo();
                    break;

                case 3:
                    StackDemo();
                    break;

                case 4:
                    LinkedListDemo();
                    break;

                case 5:
                    DictionaryDemo();
                    break;

                case 6:
                    SortedListDemo();
                    break;

                case 7:
                    HashSetDemo();
                    break;

                case 8:
                    ListDemo();
                    break;

                case 9:
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 9.");
                    break;
            }
        }
    }

    static void QueueDemo()
    {
        Queue<string> myQueue = new Queue<string>();

        myQueue.Enqueue("Pizza");
        myQueue.Enqueue("Spaghetti");
        myQueue.Enqueue("Squash Soup");
        myQueue.Enqueue("Teriyaki chicken");
        myQueue.Enqueue("Ramen");

        int itemCount = myQueue.Count;
        Console.WriteLine($"There are {itemCount} items in the queue.");

        string itemToFind = "Ramen";
        if (myQueue.Contains(itemToFind))
        {
            Console.WriteLine($"The queue contains {itemToFind}.");
        }
        else
        {
            Console.WriteLine($"The queue does not contain {itemToFind}.");
        }

        string itemToRemove = myQueue.Dequeue();
        Console.WriteLine($"Removed {itemToRemove} from the queue.");

        int itemCountTwo = myQueue.Count;
        Console.WriteLine($"There are {itemCountTwo} items in the queue.");

        Console.WriteLine("The items in the queue are:");
        foreach (string item in myQueue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
    static void PriorityQueueDemo()
    {
        PriorityQueue<string, int> items = new PriorityQueue<string, int>();

        items.Enqueue("Pizza", 1);
        items.Enqueue("Mongolian Beef", 1);
        items.Enqueue("Chicken Noodle Soup", 2);
        items.Enqueue("Spaghetti", 3);
        items.Enqueue("Tacos", 2);
        items.Enqueue("BBQ Chicken", 3);

        Console.WriteLine($"There are {items.Count} items in the queue");

        while (items.TryDequeue(out string item, out int priority))
        {
            Console.WriteLine($"Dequeued Item : {item} Priority is : {priority}");
        }
        Console.WriteLine($"There are now {items.Count} items in the queue");

    }

    static void StackDemo()
    {
        Console.WriteLine("Stack Demo");

        Stack<string> stack = new Stack<string>();

        stack.Push("Pizza");
        stack.Push("Ramen");
        stack.Push("Spaghetti");
        stack.Push("Echiladas");
        stack.Push("Tacos");

        Console.WriteLine($"The stack {(stack.Contains("Enchiladas") ? "contains" : "does not contain")} Enchiladas");
        Console.WriteLine($"There are {stack.Count} items in the stack:");

        stack.Pop();

        Console.WriteLine($"There are now {stack.Count} items in the stack");
        Console.WriteLine("Items: ");

        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }

    static void LinkedListDemo()
    {
        Console.WriteLine("Linked List Demo");

        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddFirst("pizza");
        linkedList.AddLast("tacos");
        linkedList.AddLast("spaghetti");
        linkedList.AddLast("echiladas");
        linkedList.AddLast("squash soup");

        Console.WriteLine($"The first item in the linked list is {linkedList.First.Value}");
        Console.WriteLine($"The last item in the linked list is {linkedList.Last.Value}");

        LinkedListNode<string> middleNode = linkedList.Find("spaghetti");

        linkedList.AddAfter(middleNode, "shrimp gumbo");

        linkedList.Remove("pizza");

        Console.WriteLine($"There are {linkedList.Count} items in the linked list:");

        foreach (string item in linkedList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }

    static void DictionaryDemo()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("apple", 1);
        dict.Add("banana", 2);
        dict.Add("orange", 3);
        dict.Add("grape", 4);
        dict.Add("kiwi", 5);


        Console.WriteLine("\nKeys and Values:");
        foreach (KeyValuePair<string, int> kvp in dict)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        dict.Remove("orange");
        Console.WriteLine("\nAfter removing 'orange', keys and values:");
        foreach (KeyValuePair<string, int> kvp in dict)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        Console.WriteLine("\nCount: {0}", dict.Count);
    }

    static void SortedListDemo()
    {
        Console.WriteLine("Sorted List Demo");

        SortedList<string, int> sortedList = new SortedList<string, int>();

        sortedList.Add("donuts", 4);
        sortedList.Add("lava cake", 2);
        sortedList.Add("cinnebon", 5);
        sortedList.Add("pancake", 3);
        sortedList.Add("snickerdoodle", 1);

        Console.WriteLine("The sorted list contains:");

        foreach (KeyValuePair<string, int> item in sortedList)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine();
        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        if (sortedList.ContainsKey(key))
        {
            Console.WriteLine($"Key '{key}' already exists in the sorted list.");
            Console.Write("Enter a new value: ");
            int value = int.Parse(Console.ReadLine());
            sortedList[key] = value;
            Console.WriteLine($"Updated value for key '{key}': {value}");
        }
        else
        {
            Console.Write("Enter a value: ");
            int value = int.Parse(Console.ReadLine());
            sortedList.Add(key, value);
            Console.WriteLine($"Added key-value pair: {key}: {value}");
        }

        Console.WriteLine();

        Console.Write("Enter a key to remove: ");
        string removeKey = Console.ReadLine();

        if (sortedList.ContainsKey(removeKey))
        {
            sortedList.Remove(removeKey);
            Console.WriteLine($"Removed key-value for: {removeKey}");
        }
        else
        {
            Console.WriteLine($"Key '{removeKey}' not found in the sorted list.");
        }

        Console.WriteLine();

        Console.WriteLine("Final sorted list:");

        foreach (KeyValuePair<string, int> item in sortedList)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine();
    }

    static void HashSetDemo()
    {
        HashSet<string> hashSet1 = new HashSet<string>();
        HashSet<string> hashSet2 = new HashSet<string>();
        HashSet<string> hashSet3 = new HashSet<string>();

        hashSet1.Add("apple");
        hashSet1.Add("banana");
        hashSet1.Add("orange");
        hashSet1.Add("grape");
        hashSet1.Add("peach");

        hashSet2.Add("watermelon");
        hashSet2.Add("banana");
        hashSet2.Add("kiwi");
        hashSet2.Add("pineapple");
        hashSet2.Add("peach");

        hashSet3.Add("lemon");
        hashSet3.Add("kiwi");
        hashSet3.Add("pear");
        hashSet3.Add("guava");
        hashSet3.Add("orange");

        Console.WriteLine("HashSet 1:");
        foreach (string item in hashSet1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nHashSet 2:");
        foreach (string item in hashSet2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nHashSet 3:");
        foreach (string item in hashSet3)
        {
            Console.WriteLine(item);
        }

        hashSet1.UnionWith(hashSet2);
        Console.WriteLine("\nCombined HashSet 1 and HashSet 2:");
        foreach (string item in hashSet1)
        {
            Console.WriteLine(item);
        }

        HashSet<string> duplicates = new HashSet<string>(hashSet1);
        duplicates.IntersectWith(hashSet3);
        Console.WriteLine("\nItems in HashSet 1 and HashSet 3:");
        foreach (string item in duplicates)
        {
            Console.WriteLine(item);
        }
    }

    static void ListDemo()
    {
        Console.WriteLine("List Demo");

        List<string> list = new List<string>();

        list.Add("chocolate");
        list.Add("vanilla");
        list.Add("sugar");
        list.Add("flour");
        list.Add("baking soda");

        list.AddRange(new List<string> { "eggs", "milk", "water" });

        Console.WriteLine($"The list {(list.Contains("sugar") ? "contains" : "does not contain")} sugar");

        list.Sort();
        Console.WriteLine($"There are {list.Count} items in the list:");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        list.Remove("chocolate");
        Console.WriteLine("Removed 'chocolate' froms the list:");
        Console.WriteLine();
        list.Reverse();
        Console.WriteLine($"After reversing/removing, there are {list.Count} items in the list:");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }

}