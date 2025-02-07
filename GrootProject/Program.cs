using System;
using System.Collections;
using System.Runtime.CompilerServices;


namespace Treeton;

class Program
{
    static void Main()
    {
        Node.Root peach = new Node.Root();
        peach.AddNode2("root", "Hello");
        peach.AddNode(1, "Bonjour");
        peach.AddNode(2, "Tinto");
        peach.AddNode2("Tinto", "Tinto2");
        
        peach.SetUpNodeValueColumn("acc_name", ValueColumnType.String); 
        peach.SetUpNodeValueColumn("debit", ValueColumnType.Integer);
        peach.SetUpNodeValueColumn("credit", ValueColumnType.Integer);
        peach.SetUpNodeValueColumn("sos", ValueColumnType.Boolean);
        
        
        peach.AddValueToSpecificNode2("root","acc_name","Bank");
        peach.AddValueToSpecificNode2("root","acc_name","Bank2");
        peach.AddValueToSpecificNode2("Hello","acc_name","Cash");
        peach.AddValueToSpecificNode2("Hello","credit",54);
        peach.AddValueToSpecificNode2("root","debit",102);
        peach.AddValueToSpecificNode2("root","debit",103);
        peach.AddValueToSpecificNode2("Tinto","debit",1050);
        peach.AddValueToSpecificNode2("Tinto","debit",1777);
        peach.AddValueToSpecificNode2("Tinto","acc_name","some_text");
        peach.AddValueToSpecificNode2("Tinto","acc_name","text_here");
        peach.AddValueToSpecificNode2("Bonjour","acc_name","float_leaf");
        peach.AddValueToSpecificNode2("Bonjour","sos",true);

        
        
        
        Console.WriteLine(string.Join(", ", peach.GetNodeValueColumns().Keys), peach.GetNodeValueColumns().Values);
        peach.PrintTree();

    
       




    }

 
}