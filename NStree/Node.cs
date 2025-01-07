namespace ConsoleApp1;
//cccc 1111 2223223232
public class Node
{
    private int Parent_ID; 
    private int ID; 
    private int Left_Key; 
    private int Right_Key; 
    private int Level; 
    private string Name; 

    public int getParentID() => Parent_ID;
    public void setParentID(int id) => Parent_ID = id;
    
    public int getID() => ID;
    public void setID(int id) => ID = id;
    
    public int getLeft_Key() => Left_Key;
    public void setLeft_Key(int key) => Left_Key = key;
    
    public int getRight_Key() => Right_Key;
    public void setRight_Key(int key) => Right_Key = key;
    
    public int getLevel() => Level;
    public void setLevel(int level) => Level = level;
    
    public string getName() => Name;
    public void setName(string name) => Name = name;
    
    
    public Node (int parent_id, int id, int left_key, int right_key, int level)
    {
        Parent_ID = parent_id;
        ID = id;
        Left_Key = left_key;
        Right_Key = right_key;
        Level = level;
    }

    
    public Node (int parent_id, string name)
    {
        Parent_ID = parent_id;
        Name = name;
    }


  
    
    
    
}