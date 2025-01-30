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
        peach.SetUpNodeValueColumn("debit", ValueColumnType.Integer);
        peach.SetUpNodeValueColumn("credit", ValueColumnType.Integer);
        peach.SetUpNodeValueColumn("sos", ValueColumnType.Integer);
        
        peach.AddValueToSpecificNode2("root","acc_name","Bank");
        peach.AddValueToSpecificNode2("root","acc_name","Bank2");
        peach.AddValueToSpecificNode2("Hello","acc_name","Cash");
        peach.AddValueToSpecificNode2("Hello","credit",54);
        peach.AddValueToSpecificNode2("root","debit",102);
        peach.AddValueToSpecificNode2("root","debit",103);
        peach.AddValueToSpecificNode2("Tinto","debit",1050);
        peach.AddValueToSpecificNode2("Tinto","debit",1777);
        peach.AddValueToSpecificNode2("Tinto","acc_name",888);
        peach.AddValueToSpecificNode2("Tinto","acc_name",999);
        peach.AddValueToSpecificNode2("Bonjour","sos",1024);


        var input = 10;
        bool valueColumnTypeCheck = false;
        switch (peach.GetNodeValueColumns()["debit"])
        {
            case ValueColumnType.String: 
                valueColumnTypeCheck = input is string;
                break;
            case ValueColumnType.Integer:
                valueColumnTypeCheck = input is int;
                break;
        }
        
        
        Console.WriteLine(valueColumnTypeCheck);
       
        Console.WriteLine(string.Join(", ", peach.GetNodeValueColumns().Keys), peach.GetNodeValueColumns().Values);
        peach.PrintTree();

    
       




    }

 
}