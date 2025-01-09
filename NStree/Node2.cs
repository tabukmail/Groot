namespace ConsoleApp1.NStree;

public class Node2
{
    private int _number = 0;

    public int getNumber()
    {
        return _number;
    }

    private void setNumberzzz(int number)
    {
        _number = number;
    }

    // ---------------------------------------------------------------------
    public class Tree2
    {
        private int numm = 1;

        private void setNum(int num)
        {
            numm = num;
        }
        
        void someMethod()
        {
            Node2 node = new Node2();
            node.getNumber();
            node.setNumberzzz(1);
    
            Node2.Tree2 tree = new Node2.Tree2();
            tree.setNum(1);
            
        
        }
        
        
    }
    // ---------------------------------------------------------------------

    void someMethod()
    {
        Node2 node = new Node2();
        node.getNumber();
        node.setNumberzzz(1);
    
        Node2.Tree2 tree = new Node2.Tree2();
        // tree.setNum(1);
        // tree.setNum(1);
        
    }
    
    
    
        
}

