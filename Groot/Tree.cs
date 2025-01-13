using System.Collections;

namespace ConsoleApp1.NStree;

public class Tree 
{
    private ArrayList _tree = new ArrayList{new Node(0, 1, 1, 2, 0, "root")};  
    
    public ArrayList GetTree()
    {
        return _tree;
    }

   
    public void AddNode(int parentId, string newNodeName)
    {
        
        if ((parentId > _tree.Count) || (parentId  <= 0)){
            Console.WriteLine($":: -> {parentId } is out of possible range");
            return;
        }
        
        var lefthKey = 0;
        var rightKey = 0;
        var level = 0;
        var parentRightKey = 0;
        var parentLefthKey = 0;
        
       foreach (Node? node in _tree.ToArray())
        {
            if (node != null && parentId == node.GetId())
            {
                parentRightKey = node.GetRight_Key();
                parentLefthKey = node.GetLeft_Key();
                lefthKey = node.GetRight_Key();
                rightKey = lefthKey + 1;
                level = node.GetLevel() + 1;
                node.setRight_Key(node.GetRight_Key() + 2);
                
            }
        }
       
        foreach (Node? node in _tree.ToArray())
        {
            if (node != null && node.GetLeft_Key() > parentRightKey)
            {
                node.setRight_Key(node.GetRight_Key() + 2);
                node.setLeft_Key(node.GetLeft_Key() + 2);
            }
            
            if (node != null && node.GetRight_Key() > parentRightKey && node.GetLeft_Key() < parentLefthKey)
            {
                node.setRight_Key(node.GetRight_Key() + 2);
            }
        }
       
        _tree.Add (new Node(parentId, _tree.Count + 1, lefthKey, rightKey, level, newNodeName));
        
       
       _tree.Sort();
            
       }


}

