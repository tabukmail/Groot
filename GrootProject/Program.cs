using System;
using System.Collections;
using System.Runtime.CompilerServices;
using PasswordGenerator;

namespace Treeton;

class Program
{
    static void Main()
    {
        Node.Root peach = new Node.Root();
        peach.AddNode(1, "Hello");
        peach.AddNode(1, "Bonjour");
        peach.AddNode(2, "Tinto");
        
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String); 
        peach.SetUpNodeValueColumn("debit", ValueColumnType.Int32);
        peach.SetUpNodeValueColumn("credit", ValueColumnType.Int32);
        peach.SetUpNodeValueColumn("sos", ValueColumnType.Int32);
        
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
        peach.AddValueToSpecificNode("Hello",1,300);
        peach.AddValueToSpecificNode("Hello",3,887);
        peach.AddValueToSpecificNode2("Tinto","debit",1050);
        peach.AddValueToSpecificNode2("Tinto","debit",1777);
        peach.AddValueToSpecificNode2("Tinto","acc_name",888);
        peach.AddValueToSpecificNode2("Hello","credit",777);
        
        
        
        
        Console.WriteLine(peach.GetNodeValueColumns()["acc_name"].ToString());
        Console.WriteLine(peach.GetValueOfSpecificNode("Hello", 1).GetType().ToString());
        Console.WriteLine(peach.GetValueOfSpecificNode("Hello", 1) is decimal);

        
        switch (peach.GetNodeValueColumns()["acc_name"])
        {
            case ValueColumnType.String: 
                Console.WriteLine("its string");
                break;
            case ValueColumnType.Float:
                Console.WriteLine("its float");
                break;
        }

        
        
        peach.PrintTree();

    
       




    }

 
}