using System;

using PasswordGenerator;

namespace Groot;

class Program
{
    static void Main()
    { 
       Groot.Tree peach = new Groot.Tree();
    
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String);
        Console.WriteLine(peach.GetNodeValueColumns());
        
        foreach (Groot node in peach.GetTree())
        {
        
           Console.WriteLine(node.GetNodeValues().GetValues()[0]);
           
        }


        
       
       
       
       
       
       
       
       
       
    }
}