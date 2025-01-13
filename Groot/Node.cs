namespace ConsoleApp1.NStree;

public class Node : IComparable
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
    internal void setLeft_Key(int key) => _leftKey = key;

    public int GetRight_Key() => _rightKey;
    internal void setRight_Key(int key) => _rightKey = key;

    
    
    public NodeValues GetNodeValues() => _nodeValues;
    
  
    public Node(int parentId, int id, int leftKey, int rightKey, int level, string name)
    {
        _parentId = parentId;
        _id = id;
        _leftKey = leftKey;
        _rightKey = rightKey;
        _level = level;
        _name = name;
    }

    
    public Node(int parentId, string name)
    {
        _parentId = parentId;
        _name = name;
    }

   


    public int CompareTo(object? incomingobject) 
    { 
        Node incomingNode = incomingobject as Node ?? throw new InvalidOperationException(); 
        return this._leftKey.CompareTo(incomingNode._leftKey); 
    } 



}