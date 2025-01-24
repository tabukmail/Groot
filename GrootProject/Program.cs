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
    
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String);        
        Console.WriteLine(peach.GetNodeValueColumns());
        
        peach.PrintTree();
        
        
       
       
       
       
       
       
       
    }
}