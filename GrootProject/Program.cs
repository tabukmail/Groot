using System;

using PasswordGenerator;

namespace Groot;

class Program
{
    static void Main()
    {
        
        Groot.Tree peach = new Groot.Tree();
        peach.AddNode(1, "Hello");
        peach.AddNode(1, "Bonjour");
        peach.AddValueToSpecificNode("root",0,8);
        peach.AddValueToSpecificNode("root",0,12);
        peach.AddValueToSpecificNode("Bonjour",0,20);
        peach.AddValueToSpecificNode("Bonjour",0,28);
        peach.AddValueToSpecificNode("root",1,54);
        
    
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String);        
        Console.WriteLine(peach.GetNodeValueColumns());
        
        peach.PrintTree();

        var sum = (int)(peach.GetValueOfSpecificNode("root", 0)) + (int)(peach.GetValueOfSpecificNode("Bonjour", 0));
        Console.WriteLine();
        Console.WriteLine(sum);
        








    }
}