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
        peach.AddValueToSpecificNode("Hello",1,2.5400006M);
        peach.AddValueToSpecificNode("Hello",3,130);
        peach.AddNode(2, "Tinto");
        peach.AddValueToSpecificNode("Tinto",3,130);
        
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.Float); 
        peach.SetUpNodeValueColumn("debit", ValueColumnType.Int32); 
        Console.WriteLine(peach.GetNodeValueColumns()["acc_name"].ToString());
        Console.WriteLine(peach.GetValueOfSpecificNode("Hello", 1).GetType().ToString());
     
        Console.WriteLine(peach.GetValueOfSpecificNode("Hello", 1) is decimal);

        
        
        
        
        
        
        peach.PrintTree();

    
       




    }
}