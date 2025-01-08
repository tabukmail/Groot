namespace ConsoleApp1;

public class Node : IComparable 
{
    private int _parentId;
    private int _id;
    private int _leftKey;
    private int _rightKey;
    private int _level;
    private string _name;

    public int GetParentId() => _parentId;
    public void SetParentId(int id) => _parentId = id;

    public int GetId() => _id;
    public void SetId(int id) => _id = id;

    public int GetLeft_Key() => _leftKey;
    public void setLeft_Key(int key) => _leftKey = key;

    public int GetRight_Key() => _rightKey;
    public void setRight_Key(int key) => _rightKey = key;

    public int GetLevel() => _level;
    public void SetLevel(int level) => _level = level;

    public string GetName() => _name;
    public void SetName(string name) => _name = name;
    
   
    public int CompareTo(object? incomingobject) 
    { 
        Node incomingNode = incomingobject as Node ?? throw new InvalidOperationException(); 
        return this._leftKey.CompareTo(incomingNode._leftKey); 
    } 
    
    
    
    


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






}