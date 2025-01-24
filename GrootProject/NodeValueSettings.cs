namespace Groot;

public class NodeValueSettings
{
    
    
    private static Dictionary<string, ValueColumnType> _nodeDataTypes = new Dictionary<string, ValueColumnType>(){};
    
    public  Dictionary<string, ValueColumnType> GetTypes()
    {
        return _nodeDataTypes;
    }
    
    public Dictionary<string,ValueColumnType> GetValueTypes()
    {
        return _nodeDataTypes;
    }
    
    public void SetValueType(string name, ValueColumnType type)
    {
        _nodeDataTypes.Add(name, type);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}