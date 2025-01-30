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
        peach.SetUpNodeValueColumn("debit", ValueColumnType.Int32);
        peach.SetUpNodeValueColumn("credit", ValueColumnType.Int32);
        peach.SetUpNodeValueColumn("sos", ValueColumnType.Int32);
        
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



        bool valueTypeCheck = false;
        switch (peach.GetNodeValueColumns()["acc_name"])
        {
            case ValueColumnType.String: 
                valueTypeCheck = peach.GetValueOfSpecificNode2("root", "acc_name") is string;
                break;
            case ValueColumnType.Float:
                Console.WriteLine("its float");
                break;
        }
        
        
        Console.WriteLine(valueTypeCheck);
       
        Console.WriteLine(string.Join(", ", peach.GetNodeValueColumns().Keys), peach.GetNodeValueColumns().Values);
        peach.PrintTree();

    
       




    }

 
}