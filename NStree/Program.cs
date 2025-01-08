using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TreeProject;

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


       
       
       
          // Console.WriteLine($" this is {tree.GetTree().GetValues()}");
       



       foreach (Node element in tree.GetTree())
       {
           if (element.GetId() == 3 )
           {
               element.SetNodeValues(0, 60);
           }
           
           Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, {element.GetName()}, == >>  {element.GetNodeValues()[0]}");
           
       }

       
    }
}