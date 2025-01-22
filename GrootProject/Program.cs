using System;
using PasswordGenerator;

namespace Groot;

class Program
{
    static void Main()
    { 
       Groot.Tree peach = new Groot.Tree();
       
       peach.AddNode(1, "1-1");
       peach.AddNode(1, "1-2");
       peach.AddNode(1, "1-3");
       peach.AddNode(3, "1-2-1");
       peach.AddNode(3, "1-2-2");
       peach.AddNode(3, "1-2-3");
       peach.AddNode(4, "1-3-1");
       peach.AddNode(7, "1-2-3-1");

       
       peach.AddNode(3,"dadad");
       
       
       var nodara = (Groot)peach.GetTree()[8]!;
       nodara.GetNodeValues().SetValues(0,2056);
       
       
       foreach (Groot element in peach.GetTree())
       {
           if (element.GetId() == 6 )
           {
               element.GetNodeValues().SetValues(0, 68);
               int nodeval = element.GetNodeValues().GetValues()[0];
               
               // Console.WriteLine($" nod val {nodeval}");
           }
           Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, |||  {element.GetName()}, == >>  {element.GetNodeValues().GetValues()[0]}");
       }

       
       Groot.Tree legvi = new Groot.Tree();
       legvi.AddNode(1, "1-1");
       legvi.AddNode(1, "1-2");
       
       
       foreach (Groot le in legvi.GetTree())
       {
           if (le.GetId() == 3)
           {
               le.GetNodeValues().SetValues(0,255);
           }

           foreach (var be in le.GetNodeValues().GetValues())
           {
               // Console.WriteLine($" == >>>>>>> {be} ");
           }
                // Console.WriteLine($"{le.GetName()} == >> {le.GetNodeValues().GetValues()[0]} ");
       }

       int inz = 5;
       string ins = "5";
       Console.WriteLine(inz.GetTypeCode());
       Console.WriteLine(ins.GetTypeCode());


       Console.WriteLine(peach.GetValuesOf("1-2-2", 0));

      








    }
}