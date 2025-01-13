using GrootProject.Tree;

namespace GrootProject;

class Program
{
    static void Main()
    {   
        
       Groot.Tree tree = new Groot.Tree();
       tree.AddNode(1, "1-1");
       tree.AddNode(1, "1-2");
       tree.AddNode(1, "1-3");
       tree.AddNode(3, "1-2-1");
       tree.AddNode(3, "1-2-2");
       tree.AddNode(3, "1-2-3");
       tree.AddNode(4, "1-3-1");
       tree.AddNode(7, "1-2-3-1");
       
       
       foreach (Groot element in tree.GetTree())
       {
           if (element.GetId() == 6 )
           {
               element.GetNodeValues().SetValues(0, 68);
               int nodeval = element.GetNodeValues().GetValues()[0];
               
               
               // Console.WriteLine($" nod val {nodeval}");
           }
           Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, {element.GetName()}, == >>  {element.GetNodeValues().GetValues()[0]}");
       }

       var nodara = (Groot)tree.GetTree()[7]!;
       
       

       Groot.Tree oak = new Groot.Tree();
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       

    }
}