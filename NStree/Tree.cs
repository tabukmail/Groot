using System.Collections;

namespace ConsoleApp1;

public class Tree
{

    private ArrayList list = new ArrayList{new Node(0, 1, 1, 2, 0)};  

    
    
    public ArrayList getList()
    {
        return list;
    }
    
    
    
    public void addNode(int parent_id, string name)
    {
        
        list.Add (new Node(parent_id, name));
    }
    
    public void addNode(Node node)
    {
        
        list.Add (node);
    }
// some comment

  
}