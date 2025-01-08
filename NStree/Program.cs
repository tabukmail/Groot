using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {   
        
       Tree tree = new Tree();

    
       tree.AddNode(1, "1-1");
       tree.AddNode(1, "1-2");
       tree.AddNode(1, "1-3");
       tree.AddNode(3, "1-2-1");
       tree.AddNode(3, "1-2-2");
       tree.AddNode(3, "1-2-3");
       tree.AddNode(4, "1-3-1");
       tree.AddNode(7, "1-2-3-1");
       tree.AddNode(0, "0000");
       tree.AddNode(0, "0001");
       
       foreach (Node element in tree.GetTree())
       {
           Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, {element.GetName()}");
           
       }

       
    }
}