using System;
using System.Collections;

namespace Groot;

//TODO 
// 1. DeleteNode() - option to lock node from deletion if it hes NodeValues
// 2. MoveNode()
// 3. IsLeaf()
// 4. CountNodes()
// 5. options to plug-in data source  : JSON or DB option 
// 6. name automation according parents last digit
// 7. create PrintTree() method after GetTree() method





public class Groot : IComparable
{
    private int _parentId;
    private int _id;
    private int _leftKey;
    private int _rightKey;
    private int _level;
    private string _name;
    private NodeValues _nodeValues= new NodeValues();
    

    public int GetParentId() => _parentId;
    public int GetId() => _id;
    public int GetLevel() => _level;
    
    public string GetName() => _name;
    public void SetName(string name) => _name = name;
    
    public int GetLeft_Key() => _leftKey;
    private void setLeft_Key(int key) => _leftKey = key;

    public int GetRight_Key() => _rightKey;
    private void setRight_Key(int key) => _rightKey = key;

    
    
    public NodeValues GetNodeValues() => _nodeValues;


    private Groot(int parentId, int id, int leftKey, int rightKey, int level, string name)
    {
        _parentId = parentId;
        _id = id;
        _leftKey = leftKey;
        _rightKey = rightKey;
        _level = level;
        _name = name;
    }

    
    private Groot(int parentId, string name)
    {
        _parentId = parentId;
        _name = name;
    }

   


    public int CompareTo(object? incomingobject) 
    { 
        Groot incomingNode = incomingobject as Groot ?? throw new InvalidOperationException(); 
        return this._leftKey.CompareTo(incomingNode._leftKey); 
    } 
        /// ===================================== bested class ============================
        public class Tree 
            {
                private readonly ArrayList _tree = [new Groot(0, 1, 1, 2, 0, "root")];  
                
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
                    
                   foreach (Groot? node in _tree.ToArray())
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
                   
                    foreach (Groot? node in _tree.ToArray())
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
                   
                    _tree.Add (new Groot(parentId, _tree.Count + 1, lefthKey, rightKey, level, newNodeName));
                    
                   
                   _tree.Sort();
                        
                   }
                
               
                
                
            
            
            }


}

