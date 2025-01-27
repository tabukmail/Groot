using System;
using System.Collections;
using PasswordGenerator;

namespace Groot;

class Program
{
    static void Main()
    {
        Node.Root peach = new Node.Root();
        peach.AddNode(1, "Hello");
        peach.AddNode(1, "Bonjour");
        peach.AddValueToSpecificNode("root",0,8);
        peach.AddValueToSpecificNode("root",0,12);
        peach.AddValueToSpecificNode("root",0,10);
        peach.AddValueToSpecificNode("root",1,11);
        peach.AddValueToSpecificNode("root",4,14);
        peach.AddValueToSpecificNode("Bonjour",0,20);
        peach.AddValueToSpecificNode("Bonjour",0,28);
        peach.AddValueToSpecificNode("Bonjour",1,87);
        peach.AddValueToSpecificNode("Bonjour",1,64);
        peach.AddValueToSpecificNode("Bonjour",1,128);
        peach.AddValueToSpecificNode("Bonjour",1,98);
        peach.AddValueToSpecificNode("Hello",2,110);
        
        
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String);        
        Console.WriteLine(peach.GetNodeValueColumns());
        
        peach.PrintTree();

        var sum = (int)(peach.GetValueOfSpecificNode("root", 0)) + (int)(peach.GetValueOfSpecificNode("Bonjour", 0));
        
        Console.WriteLine($"This is sum {sum}");

        
        
        //---check if the value exists in a specific column index NOT in ROW 
        foreach (Node node in peach.GetTree())
        {
            int indexToCheck = 2;

            if (node.GetNodeData().GetNodeValues().Count is 0 || indexToCheck >= node.GetNodeData().GetNodeValues().Count)
            {
                Console.WriteLine("Oops no value on this index");
            }
            else
            {
                Console.WriteLine($"{node.GetNodeData().GetNodeValues()[indexToCheck]}");
            }
        }

        //---working on node values if value is missed for aggregation in the ROW    
        //Console.WriteLine(peach.PrintAllValuesOfNode("root"));
        foreach (var data in peach.GetAllValuesOfNode("root"))
        {
            Console.WriteLine($"working on node values {data}");
        }

        Console.WriteLine($"value on sp index ? > {peach.GetValueOfSpecificNode("Hello", 1)}");




    }
}