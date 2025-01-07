using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {   
        
       Tree tree = new Tree();
       tree.addNode(1,"first node");
       tree.addNode(2,"second node");

       
       
       foreach (Node element in tree.getList())
       {
           Console.WriteLine(element.getParentID());
       }

        // some comment
       
      
 

    }
}